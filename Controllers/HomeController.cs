using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RMDb.Models;

namespace RMDb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (username=="logic" && password=="letlogicpass")
        {
            return RedirectToAction("Index", "Movies");
        }
        else
        {
            
            ViewData["Error"] = "Invalid username or password.";
            return View("Index");
        }
    }

    public IActionResult NewView()
    {
        return View();
    }

}

