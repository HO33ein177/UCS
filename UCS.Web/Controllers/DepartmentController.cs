using Microsoft.AspNetCore.Mvc;
using UCS.Application.Common.Interfaces;
using UCS.Domain.Entities;

namespace UniCourseSelect.Controllers;

public class DepartmentController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public DepartmentController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    // GET
    public IActionResult Index()
    {
        var departments = _unitOfWork.Department.GetAll();
        
        return View(departments);
    }

    public IActionResult Create()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Create(Department department)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Department.Add(department);
            _unitOfWork.Department.SaveChanges();

            return RedirectToAction("Index");
        }

        return View(department);
    }


    public IActionResult Delete(int departmentId)
    {
        var departmentFromDb = _unitOfWork.Department.Get(u => u.DepartmentId == departmentId);

        if (departmentFromDb is null)
        {
            return RedirectToAction("Error", "Home");
        }

        return View(departmentFromDb);
        
    }

    [HttpPost]
    public IActionResult Delete(Department departmentObj)
    {
        Department departmentFromDb = _unitOfWork.Department.Get(u => u.DepartmentId == departmentObj.DepartmentId);
        
        
        if (departmentFromDb is not null)
        {
            _unitOfWork.Department.Remove(departmentFromDb);
            _unitOfWork.Department.SaveChanges();
            
            return RedirectToAction("Index");

        }

        return View();
    }
}