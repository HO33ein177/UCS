using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using UCS.Application.Services.Implementation;
using UCS.Application.Services.Interfaces;
using UCS.Domain.Entities;

namespace UniCourseSelect.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IStudentService _studentService;
        // GET
        public DashboardController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            string id = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var student = _studentService.GetStudentById(id) ;
            if (student == null)
            {
                return NotFound();
            }
            // var courses = _studentService.
            return View(student);
        }
        
        public async Task<IActionResult> GetDebtsPurchasesBarChartData(long UMID)
        {
            return Json(await _studentService.GetDebtsPurchasesBarChartData(UMID));

        }
    }
}
