using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using System.Diagnostics;

namespace TodoList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Logica para cuando se va la pagina index
        List<object>listaObjetos = new List<object>();
        
        //lista de recomendaciones random
        List<object>recomendaciones  = new List<object>
        {
          new
          {
              recomendacion = "Da gracias a dios por un nuevo dia",
              pensamiento = "Todos los dias pueden ser buenos si tu asi te lo propones, no necesitas de nada ni de nadie para ser feliz, solo tu"
          },
          new
          {
              recomendacion = "Mantente hidratado",
              pensamiento = "Una mente sana tambien implica un cuerpo sano"
          },
          new
          {
              recomendacion = "No importa, haz lo que te haga feliz",
              pensamiento = "Si te hace feliz, no importa lo que hagas al final eso es lo importante."
          },
          new
          {
              recomendacion = "No olvidez lo valioso que eres",
              pensamiento = "Que nada ni nadie cambie esa persona increible que tu eres, que la vida y el mundo vean quien eres tu"
          }
        };
        
        ViewBag.LoggedUser = "Edwin Orellana";
        //Obteniendo un consejo random para el dia
        var randomNumber = new Random().Next(0,4);
        ViewBag.ConsejoDelDia = recomendaciones[randomNumber];       
        
        
        return View(listaObjetos);
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
