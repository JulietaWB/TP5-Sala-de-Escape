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
            case 1: return habitacion1();
            break;
                
            case 2: return habitacion2();
            break;
                
            case 3: return habitacion3();
            break;
                
            case 4: return habitacion4();
            break;
                
            case 5: return habitacion5();
            break;
                
            default: 
            break;
        }
        return View();
    }

    public IActionResult Habitacion (int sala, string clave)
    {
        if (sala==Escape.GetEstadoJuego())
        {
            if (Escape.ResolverSala(sala, clave)==true) //si ganó
            {
                switch (Escape.GetEstadoJuego()+1) 
                {
                    case 2: return habitacion2();
                    break;
                    
                    case 3: return habitacion3();
                    break;
                    
                    case 4: return habitacion4();
                    break;
                    
                    case 5: return habitacion5();
                    break;

                    case 6: return Victoria();
                    break;
                    
                    default: 
                    break;
                }
            }
            else
            {
                switch (Escape.GetEstadoJuego()) 
                {
                    case 2: return habitacion2();
                    break;
                    
                    case 3: return habitacion3();
                    break;
                    
                    case 4: return habitacion4();
                    break;
                    
                    case 5: return habitacion5();
                    break;

                    case 6: return Victoria();
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
                case 1: return habitacion1();
                break;
                
                case 2: return habitacion2();
                break;
                
                case 3: return habitacion3();
                break;
                
                case 4: return habitacion4();
                break;
                
                case 5: return habitacion5();
                break;
                
                default: 
                break;
            }
        }


        return View(); 
        
    }

}
