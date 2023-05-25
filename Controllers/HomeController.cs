using Microsoft.AspNetCore.Mvc;

namespace LessCompile.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
