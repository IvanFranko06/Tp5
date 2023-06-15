using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp5.Models;

namespace tp5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult Creditos()
    {
        return View("Creditos");
    }
    public IActionResult Victoria()
    {
        return View("Victoria");
    }

    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
     public IActionResult Comenzar()
    {   int numSala=Escape.GetEstadoJuego();
        
        return View("Sala"+numSala);
    }

    public IActionResult Habitacion(int sala, string Incognita)
    {
      bool pasa= Escape.ResolverSala(sala,Incognita);
      if (pasa== false)
      {
        ViewBag.Error="respuesta equivocada";
        return View("Sala"+sala);
      }
      else
      {
        sala = Escape.GetEstadoJuego();
        return View("Sala"+sala);
      }

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
