using Tourism;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebApp.Controllers;

public class HomeController : Controller
{
    private SiteStore store = new();
    private Site model;

    public HomeController()
    {
        model = store.Load("Home");
    }

    public IActionResult Index()
    {
        return View(model);                     // render /Views/Home/Index.cshtml
    }

    [HttpPost]
    public IActionResult Register(string person)
    {
        var visitor = model.GetVisitor(person);
        visitor.Visit();
        store.Save(model);
        return RedirectToAction("Index");
    }
}