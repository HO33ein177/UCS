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
        
        _unitOfWork.Professor.Add(professorVm.Professor);
        _unitOfWork.Professor.SaveChanges();

        professorVm.DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
        {
            Text = u.Name,
            Value = u.DepartmentId.ToString()
        });

        professorVm.StateList = ProfessorService.GetProfessorStateSelectList();

        return View(professorVm);
    }


    public IActionResult Delete(int profId)
    {
        ProfessorVM profVm = new ProfessorVM()
        {
            DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.DepartmentId.ToString(),
            }),
            Professor = _unitOfWork.Professor.Get(u => u.UniqueMemberId == profId)
        };

        if (profVm.Professor is null)
        {
            return RedirectToAction("Error", "Home");
        }

        return View(profVm);
    }



    [HttpPost]
    public IActionResult Delete(ProfessorVM professorVM)
    {
        Professor professor = _unitOfWork.Professor.Get(u => u.UniqueMemberId == professorVM.Professor.UniqueMemberId);

        if (professor is not null)
        {
            _unitOfWork.Professor.Remove(professor);
            _unitOfWork.Professor.SaveChanges();

            return RedirectToAction("Index");
        }

        return View();
    }


    public IActionResult Update(int profId)
    {
        ProfessorVM professorVM = new ProfessorVM()
        {
            DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.DepartmentId.ToString(),
            }),
            StateList = ProfessorService.GetProfessorStateSelectList(),


            Professor = _unitOfWork.Professor.Get(u => u.UniqueMemberId == profId)
        };

        if (professorVM is null)
        {
            return RedirectToAction("Error", "Home");
        }

        return View(professorVM);


    }

    [HttpPost]
    public IActionResult Update(ProfessorVM professorVM)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Professor.UpdateProfessor(professorVM.Professor);
            _unitOfWork.Professor.SaveChanges();

            return RedirectToAction("Index");
        }

        professorVM.DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
        {
            Text = u.Name,
            Value = u.DepartmentId.ToString(),
        });
        professorVM.StateList = ProfessorService.GetProfessorStateSelectList();

        return View(professorVM);

    }

}