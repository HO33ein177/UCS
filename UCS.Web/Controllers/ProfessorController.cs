using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UCS.Application.Common.Interfaces;
using UCS.Application.Common.Utilities;
using UCS.Domain.Entities;
using UCS.Infrastracture.Data;
using UniCourseSelect.ViewModels;

namespace UniCourseSelect.Controllers;

public class ProfessorController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public ProfessorController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    
    // GET
    public IActionResult Index()
    {
        var professors = _unitOfWork.Professor.GetAll();
        
        return View(professors);
    }

    public IActionResult Create()
    {
        ProfessorVM professorVm = new ProfessorVM()
        {
            DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.DepartmentId.ToString()
            }),
            
            StateList = ProfessorService.GetProfessorStateSelectList()
            
        };
        
        return View(professorVm);
    }

    [HttpPost]
    public IActionResult Create(ProfessorVM professorVm)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Professor.Add(professorVm.Professor);
            _unitOfWork.Professor.SaveChanges();

            return View("Index");
        }

        professorVm.DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
        {
            Text = u.Name,
            Value = u.DepartmentId.ToString()
        });

        professorVm.StateList = ProfessorService.GetProfessorStateSelectList();

        return View(professorVm);
    }
    
}