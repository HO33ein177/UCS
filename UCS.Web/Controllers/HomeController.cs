using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UCS.Application.Common.Interfaces;
using UCS.Application.Common.Utilities;
using UCS.Domain.Entities;
using UniCourseSelect.Models;
using UniCourseSelect.ViewModels;

namespace UniCourseSelect.Controllers;

public class HomeController : Controller
{
    private readonly IUnitOfWork _unitOfWork;


    public HomeController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        StudentVM studentVM = new StudentVM()
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
            })


            //     Enum.GetValues(typeof(StudentState)).Cast<StudentState>().Select(v => new SelectListItem {
            //     Text = v.ToString(),
            //     Value = ((int)v).ToString()
            // }).ToList()
        };

        return View(studentVM);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}