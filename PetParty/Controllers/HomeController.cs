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
        HttpContext.Session.SetString("LastPet",newPet.Name);
        // FakePetDb.SaveChanges() <-- this is the only difference when we actually save to our db!
        return RedirectToAction("AllPets");
    }

    [HttpGet("pets")]
    public IActionResult AllPets()
    {
        string? LastPet = HttpContext.Session.GetString("LastPet");
        if (LastPet == null)
        {
            return RedirectToAction("Index");
        }
        return View(FakePetDb);
    }

    [HttpGet("viewmodel")]
    public ViewResult VMFun()
    {
        List<string> PassedValue = ["Bob","Alice"];
        return View("VMFun",PassedValue);
    }

    [HttpPost("pets/filter")]
    public RedirectToActionResult SetFilter(int limit)
    {
        HttpContext.Session.SetInt32("Limit", limit);
        return RedirectToAction("AllPets");
    }

    [HttpPost("pets/filter/clear")]
    public RedirectToActionResult ClearFilter()
    {
        // HttpContext.Session.Clear();
        HttpContext.Session.Remove("Limit");
        return RedirectToAction("AllPets");
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
