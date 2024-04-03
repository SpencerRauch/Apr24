using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers;
// [Route("pizza")]
public class FirstController : Controller
{
    //@app.route("/dldl",methods=["POST","GET"])
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "<h1>Hello from the controller</h1>";
    }

    [HttpGet("two")]
    public string PageTwo()
    {
        return "Yup two pages now, this is working";
    }

    [HttpGet("params/{id}/{name}")]
    public ViewResult Params(int id, string name)
    {
        ViewBag.id = id;
        ViewBag.name = name;
        return View();
    }

    [HttpGet("view")]
    public ViewResult FirstView()
    {
        return View("FirstView");
    }

    [HttpGet("form")]
    public ViewResult FirstForm()
    {
        return View();
    }

    // [HttpPost("process")]
    // public RedirectResult Process(int id, string name)
    // {
    //     Console.WriteLine($"{name} supplied id: {id}");
    //     return Redirect($"params/{id}/{name}");
    // }

    // [HttpPost("process")]
    // public RedirectToActionResult Process(int id, string name)
    // {
    //     Console.WriteLine($"{name} supplied id: {id}");
    //     return RedirectToAction("Params", new {id=id,name=name});
    // }

    [HttpPost("process")]
    public IActionResult Process(int id, string name)
    {
        Console.WriteLine($"{name} supplied id: {id}");
        if (id == 123)
        {
            return View("SecretView");
        }
        return RedirectToAction("Params", new {id=id,name=name});
    }



    [HttpGet("{**path}")]
    public string Lost()
    {
        return "I think you're lost";
    }
}