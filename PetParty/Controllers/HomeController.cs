using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetParty.Models;

namespace PetParty.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private static List<Pet> FakePetDb = new();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        List<SelectListItem> Options = new()
        {
            new SelectListItem("--- please choose ---","",true,true),
            new SelectListItem("Bear","Bear"),
            new SelectListItem("Bobcat","Bobcat"),
            new SelectListItem("Deer","Deer")
        };
        ViewBag.Options = Options;
        return View("Index");
    }

    [HttpPost("process")]
    public IActionResult Process(Pet newPet)
    {
        if (!ModelState.IsValid)
        {
            var message = string.Join(" | ", ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage));
            Console.WriteLine(message);
        }
        // Console.WriteLine($"{newPet.Name} is a {newPet.Age} year(s) old {newPet.Species} they {(newPet.Urbanized ? "are":"aren't")} urbanized");
        if(!ModelState.IsValid)
        {
            
            return Index();
        }
        FakePetDb.Add(newPet);
        // FakePetDb.SaveChanges() <-- this is the only difference when we actually save to our db!
        return RedirectToAction("AllPets");
    }

    [HttpGet("pets")]
    public ViewResult AllPets()
    {
        return View(FakePetDb);
    }

    [HttpGet("viewmodel")]
    public ViewResult VMFun()
    {
        List<string> PassedValue = ["Bob","Alice"];
        return View("VMFun",PassedValue);
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
