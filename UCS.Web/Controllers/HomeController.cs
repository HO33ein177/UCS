using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UCS.Application.Common.Interfaces;
using UniCourseSelect.Models;

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
        return View();
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