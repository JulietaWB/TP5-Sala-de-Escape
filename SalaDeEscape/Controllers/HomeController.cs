using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalaDeEscape.Models;

namespace SalaDeEscape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {


        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Comenzar ()
    {
        int sala=Escape.GetEstadoJuego();


        switch (sala) 
        {
            case 1: 
                ViewBag.Titulo = "Habitacion 1";
                ViewBag.Desc="Ay, ¿dónde dejé mi libreta?";
                ViewBag.Img="\wwwroot\images\habitacion1.png";
                break;
                
            case 2: 
                ViewBag.Titulo = "Habitacion 2";
                ViewBag.Desc="No puedo recordar mi nombre…";
                ViewBag.Img="\wwwroot\images\habitacion2.png";
                break;
                
            case 3:
                ViewBag.Titulo = "Habitacion 3";
                ViewBag.Desc=" ¿Cuál era el nombre de mi banco…?";
                ViewBag.Img="\wwwroot\images\habitacion3.png"; 
            break;
                
            case 4:
                ViewBag.Titulo = "Habitacion 4";
                ViewBag.Desc="No me acuerdo cuál de estos es mi documento.";
                ViewBag.Img="\wwwroot\images\habitacion4.png";
            break;
                
            case 5:
                ViewBag.Titulo = "\wwwroot\images\habitacion5.png";
                ViewBag.Desc="Este diario… mi clave del banco estaba acá, en algún lado.";
                ViewBag.Img="";
            break;
                
            default: 
            break;
        }
        return View("Habitacion");
    }

    public IActionResult Habitacion (int sala, string clave)
    {
        if (sala==Escape.GetEstadoJuego()) //si está bien la sala
        {
            if (Escape.ResolverSala(sala, clave)==true) //si ganó
            {
                switch (Escape.GetEstadoJuego()+1) 
                {
                    case 2: 
                        ViewBag.Titulo = "Habitacion 2";
                        ViewBag.Desc="No puedo recordar mi nombre…";
                        ViewBag.Img="\wwwroot\images\habitacion2.png";
                        break;
                        
                    case 3:
                        ViewBag.Titulo = "Habitacion 3";
                        ViewBag.Desc="¿Cuál era el nombre de mi banco…?";
                        ViewBag.Img="\wwwroot\images\habitacion3.png"; 
                    break;
                        
                    case 4:
                        ViewBag.Titulo = "Habitacion 4";
                        ViewBag.Desc="No me acuerdo cuál de estos es mi documento.";
                        ViewBag.Img="\wwwroot\images\habitacion4.png";
                    break;
                        
                    case 5:
                        ViewBag.Titulo = "\wwwroot\images\habitacion5.png";
                        ViewBag.Desc="Este diario… mi clave del banco estaba acá, en algún lado.";
                        ViewBag.Img="";
                    break;

                    case 6: return View("Victoria");
                    break;
                    
                    default: 
                    break;
                }
            }
            else
            {
                switch (Escape.GetEstadoJuego()) 
                {
                    case 2: 
                        ViewBag.Titulo = "Habitacion 2";
                        ViewBag.Desc="No puedo recordar mi nombre…";
                        ViewBag.Img="\wwwroot\images\habitacion2.png";
                        break;
                        
                    case 3:
                        ViewBag.Titulo = "Habitacion 3";
                        ViewBag.Desc="¿Cuál era el nombre de mi banco…?";
                        ViewBag.Img="\wwwroot\images\habitacion3.png"; 
                    break;
                        
                    case 4:
                        ViewBag.Titulo = "Habitacion 4";
                        ViewBag.Desc="No me acuerdo cuál de estos es mi documento.";
                        ViewBag.Img="\wwwroot\images\habitacion4.png";
                    break;
                        
                    case 5:
                        ViewBag.Titulo = "\wwwroot\images\habitacion5.png";
                        ViewBag.Desc="Este diario… mi clave del banco estaba acá, en algún lado.";
                        ViewBag.Img="";
                    break;

                    case 6: return View("Victoria");
                    break;
                    
                    default: 
                    break;
                }
            }
        }
        else 
        {
            switch (Escape.GetEstadoJuego()) 
            {
               case 1: 
                ViewBag.Titulo = "Habitacion 1";
                ViewBag.Desc="Ay, ¿dónde dejé mi libreta?";
                ViewBag.Img="\wwwroot\images\habitacion1.png";
                break;
                
            case 2: 
                ViewBag.Titulo = "Habitacion 2";
                ViewBag.Desc="No puedo recordar mi nombre…";
                ViewBag.Img="\wwwroot\images\habitacion2.png";
                break;
                
            case 3:
                ViewBag.Titulo = "Habitacion 3";
                ViewBag.Desc="¿Cuál era el nombre de mi banco…?";
                ViewBag.Img="\wwwroot\images\habitacion3.png"; 
            break;
                
            case 4:
                ViewBag.Titulo = "Habitacion 4";
                ViewBag.Desc="No me acuerdo cuál de estos es mi documento.";
                ViewBag.Img="\wwwroot\images\habitacion4.png";
            break;
                
            case 5:
                ViewBag.Titulo = "Habitacion 5";
                ViewBag.Desc="Este diario… mi clave del banco estaba acá, en algún lado.";
                ViewBag.Img="\wwwroot\images\habitacion5.png"; 
            break;
                
                default: 
                break;
            }
        }


        return View("Habitacion");     
    }

}
