using Microsoft.AspNetCore.Mvc;
using UCS.Application.Common.Interfaces;

namespace UniCourseSelect.Controllers;

public class CourseController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public CourseController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    // GET
    public IActionResult Index()
    {
        var courses = _unitOfWork.Course.GetAll();
        
        return View(courses);
    }

    public IActionResult Create()
    {
        return View();
    }
    
    
}