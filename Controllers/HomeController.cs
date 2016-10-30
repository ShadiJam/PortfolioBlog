using Microsoft.AspNetCore.Mvc;

[Route("/")]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Root(){
        return View();
    }

    [HttpGet("Home/Index/{username?}")]
    public IActionResult Index(string username = "you")
    {
        ViewData["Message"] = "Some extra info can be sent to the view";
        ViewData["Username"] = username;
        return View(); // View(new Student) method takes an optional object as a "model", typically called a ViewModel
    }
    [HttpGet("Home/About")]
    public IActionResult About()
    {
        return View();
    }
}