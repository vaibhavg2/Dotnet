using Microsoft.AspNetCore.Mvc;

namespace BasicWebApp.Controllers;

public class GreeterController : Controller
{
    public IActionResult Clock()
    {
        return Content($"Current time is {DateTime.Now}");
    }

    public IActionResult Greet([FromServices] ICounter ctr, string id = "Visitor")
    {
        int count = ctr.CountNext(id);
        ViewBag.Visitor = new { Person = id, Visits = count };
        if((count % 2) == 1)
            return View("Welcome"); // render       /Views/Greeter/Welcome.cshtml
        return View("Hello");
    }
}