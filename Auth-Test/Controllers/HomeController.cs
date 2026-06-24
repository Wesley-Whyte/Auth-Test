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
        HomeViewModel ViewModel = new HomeViewModel()
        {
            EnvironVariable = _configuration["Env:Variable"],
            AppConfigVariable = _configuration["AppConfig:Variable"],
            KeyVaultVariable = _configuration["KeyVault:Variable"],
            KeyVaultVariableAppConfig = _configuration["KeyVault:Variable:AppConfig"],
            KeyVaultSecret = _configuration["KeyVault:Secret"],
            KeyVaultSecretAppConfig = _configuration["KeyVault:Secret:AppConfig"]
        };
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
