using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using UCS.Application.Common.Interfaces;
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
        };
        
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
            Student = _unitOfWork.Student.Get(u => u.StudentId == studentId)
        };

        if (studentVm.Student is null)
        {
            return RedirectToAction("Error", "Home");
        }

        return View(studentVm);
    }

    [HttpPost]
    public IActionResult Create(StudentVM studentVm)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Student.Add(studentVm.Student);
            _unitOfWork.Student.SaveChanges();

            return RedirectToAction("Index");
        }

        studentVm.DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
        {
            Text = u.Name,
            Value = u.DepartmentId.ToString(),
        }); 
        
        return View(studentVm);
    
    }

    [HttpPost]
    public IActionResult Delete(StudentVM studentVm)
    {
        Student studentFromDb = _unitOfWork.Student.Get(u => u.StudentId == studentVm.Student.StudentId);

        if (studentFromDb is not null)
        {
            _unitOfWork.Student.Remove(studentFromDb);
            _unitOfWork.Student.SaveChanges();

            return RedirectToAction("Index");
        }

        return View();
    }
    
    
    
    
    
    
    
    
    
}