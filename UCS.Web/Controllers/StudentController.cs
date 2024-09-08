using System.Net;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using UCS.Application.Common.Interfaces;
using UCS.Application.Common.Utilities;
using UCS.Domain.Entities;
using UniCourseSelect.ViewModels;

namespace UniCourseSelect.Controllers;

public class StudentController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _webHostEnvironment;
    
    public StudentController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
    {
        _unitOfWork = unitOfWork;
        _webHostEnvironment = webHostEnvironment;
    }
    
    
    
    // GET
    public IActionResult Index()
    {
        var students = _unitOfWork.Student.GetAll();
        
        return View(students);
    }

    public IActionResult Create()
    {
        StudentVM studentVm = new StudentVM()
        {
            DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.DepartmentId.ToString(),
                }),
            StateList = StudentService.GetStudentStateSelectList(),
            
            DegreeList = Enum.GetValues(typeof(Degree)).Cast<Degree>().Select(v => new SelectListItem {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(),
            
            MajorList = Enum.GetValues<Major>().Cast<Major>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            })
            
                
            //     Enum.GetValues(typeof(StudentState)).Cast<StudentState>().Select(v => new SelectListItem {
            //     Text = v.ToString(),
            //     Value = ((int)v).ToString()
            // }).ToList()
        };
        
        return View(studentVm);
    }
    
    [HttpPost]
    public IActionResult Create(StudentVM studentVm)
    {
        bool UMIDExists = _unitOfWork.Student.Any(u => u.UniqueMemberId == studentVm.Student.UniqueMemberId);

        if (ModelState.IsValid && !UMIDExists)
        {
            _unitOfWork.Student.Add(studentVm.Student);
            _unitOfWork.Student.SaveChanges();

            TempData["success"] = "Student added successfully";
            return RedirectToAction("Index");
        }
        if (UMIDExists) TempData["error"] = "UMID already exists!";
        else TempData["error"] = "Create operation was unsuccessful!";

        studentVm.DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
        {
            Text = u.Name,
            Value = u.DepartmentId.ToString(),
        });

        studentVm.StateList = StudentService.GetStudentStateSelectList();
        
        return View(studentVm);
    
    }

    public IActionResult Delete(int studentId)
    {
        StudentVM studentVm = new StudentVM()
        {
            DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.DepartmentId.ToString(),
            }),
            Student = _unitOfWork.Student.Get(u => u.UniqueMemberId == studentId)
        };

        if (studentVm.Student is null)
        {
            return RedirectToAction("Error", "Home");
        }

        return View(studentVm);
    }

    

    [HttpPost]
    public IActionResult Delete(StudentVM studentVm)
    {
        Student studentFromDb = _unitOfWork.Student.Get(u => u.UniqueMemberId == studentVm.Student.UniqueMemberId);

        if (studentFromDb is not null)
        {
            _unitOfWork.Student.Remove(studentFromDb);
            _unitOfWork.Student.SaveChanges();

            return RedirectToAction("Index");
        }

        return View();
    }


    public IActionResult Update(int studentId)
    {
        StudentVM studentVm = new StudentVM()
        {
            DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.DepartmentId.ToString(),
            }),
            StateList = StudentService.GetStudentStateSelectList(),

            DegreeList = Enum.GetValues(typeof(Degree)).Cast<Degree>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(),

            MajorList = Enum.GetValues<Major>().Cast<Major>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }),
            
            Student = _unitOfWork.Student.Get(u => u.UniqueMemberId == studentId)
        };

        if (studentVm is null)
        {
            return RedirectToAction("Error", "Home");
        }

        return View(studentVm);


    }

    [HttpPost]
    public IActionResult Update(StudentVM studentVm)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Student.UpdateStudent(studentVm.Student);
            _unitOfWork.Student.SaveChanges();

            return RedirectToAction("Index");
        }

        studentVm.DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
        {
            Text = u.Name,
            Value = u.DepartmentId.ToString(),
        });
        studentVm.StateList = StudentService.GetStudentStateSelectList();

        studentVm.DegreeList = Enum.GetValues(typeof(Degree)).Cast<Degree>().Select(v => new SelectListItem
        {
            Text = v.ToString(),
            Value = ((int)v).ToString()
        }).ToList();

        studentVm.MajorList = Enum.GetValues<Major>().Cast<Major>().Select(v => new SelectListItem
        {
            Text = v.ToString(),
            Value = ((int)v).ToString()
        });

        return View(studentVm);

    }
    
    
    
    
    
    
    
}