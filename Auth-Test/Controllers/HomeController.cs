using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Auth_Test.Models;

namespace Auth_Test.Controllers;

public class HomeController : Controller
{
    private readonly IConfiguration _configuration;

    public HomeController(IConfiguration configuration)
        => _configuration = configuration;

    public IActionResult Index()
    {
        HomeViewModel ViewModel = new HomeViewModel() { content = _configuration["Env:Variable"] };
        return View(ViewModel);
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
}
