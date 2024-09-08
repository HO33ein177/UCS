using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UCS.Domain.Entities;
using UCS.Application.Common.Utilities;
using UniCourseSelect.ViewModels;
using UCS.Infrastracture.Data;
namespace UniCourseSelect.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(ApplicationDbContext db,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

            if (!_roleManager.RoleExistsAsync(SD.Role_Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).Wait();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Student)).Wait();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Professor)).Wait();
            }
        }
        //GET
        public IActionResult Login(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            LoginVM loginVM = new LoginVM()
            {
                RedirectUrl = returnUrl,
            };
            return View(loginVM);
        }
        //POST 
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = _db.Users.FirstOrDefault(u => u.UniqueMemberId == loginVM.UniqueMemberId);
                if (user is not null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user,
                        loginVM.Password, loginVM.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {

                        if (string.IsNullOrEmpty(loginVM.RedirectUrl))
                        {
                            return RedirectToAction(nameof(Index), "Home");
                        }
                        else
                        {
                            return LocalRedirect(loginVM.RedirectUrl);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid login attempt");
                    }
                }
            }
            return View(loginVM);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> Logout(LoginVM loginVM)
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //GET
        public IActionResult Register(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            
            return RedirectToAction("Create", "Student");
        }

        //POST 
        [HttpPost]
        public async Task<IActionResult> Register(StudentVM studentVM)
        {
            if (ModelState.IsValid)
            {
                //var umid = SD.GenerateUMID(_db.Students);

                Student student = new Student()
                {
                    UniqueMemberId = studentVM.Student.UniqueMemberId,//umid,
                    FullName = studentVM.Student.FullName,
                    Email = studentVM.Email,
                    NormalizedEmail = studentVM.Email.ToUpper(),
                    EmailConfirmed = true,
                    UserName = studentVM.Email,
                    PhoneNumber = studentVM.PhoneNumber,
                    DepartmentId = studentVM.Student.DepartmentId,
                };
                var result = await _userManager.CreateAsync(student, studentVM.Password);
                if (result.Succeeded)
                {
                 
                    await _userManager.AddToRoleAsync(student,SD.Role_Student);

                    if (string.IsNullOrEmpty(studentVM.RedirectUrl))
                    {
                        return RedirectToAction(nameof(Index), "Home");
                    }
                    else
                    {
                        return LocalRedirect(studentVM.RedirectUrl);
                    }
                }
                string errorInfo = "Account creation was unsuccessful!";
                

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    errorInfo +="\n"+ error.Description;

                }
                TempData["error"] = errorInfo;
            }
           

            return RedirectToAction("Login", "Account");
        }
    }
}
