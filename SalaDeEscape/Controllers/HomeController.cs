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
        Escape.InicializarJuego();

        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Creditos()
    {
        return View();
    }

    public IActionResult Comenzar ()
    {
        int sala=Escape.GetEstadoJuego();
        ViewBag.Sala = sala;

        switch (sala) 
        {
            case 1: 
                ViewBag.Titulo = "Habitacion 1";
                ViewBag.Desc="Ay, ¿dónde dejé mi libreta?";
                ViewBag.Img="/images/habitacion1.png";
                ViewBag.Pista1="Buscá el código.";
                ViewBag.Pista2="Está cerca de la computadora.";
                return View("Habitacion1");
                break;
                
            case 2: 
                ViewBag.Titulo = "Habitacion 2";
                ViewBag.Desc="No puedo recordar mi nombre…";
                ViewBag.Img="/images/habitacion2.png";
                ViewBag.Pista1="Perdí mis anteojos, y sin ellos no puedo lograr leer mi nombre.";
                ViewBag.Pista2="Soy una mujer.";
                return View("Habitacion");
                break;
                
            case 3:
                ViewBag.Titulo = "Habitacion 3";
                ViewBag.Desc=" ¿Cuál era el nombre de mi banco…?";
                ViewBag.Img="/images/habitacion3.png"; 
                ViewBag.Pista1="Están direcciones las dejé de ayuda memoria, pero no logro identificar cual pertenece al banco.";
                ViewBag.Pista2="Si todavía no entendiste, fijate si alguna de estas coincide con un banco.";
                return View("Habitacion3");
            break;
                
            case 4:
                ViewBag.Titulo = "Habitacion 4";
                ViewBag.Desc="No me acuerdo cuál de estos es mi documento.";
                ViewBag.Img="/images/habitacion4.png";
                ViewBag.Pista1="No me acuerdo cuál es mi documento, pero sí recuerdo que son mis hijos.";
                ViewBag.Pista2="Las fechas de nacimiento te pueden resultar de gran ayuda.";
                return View("Habitacion");
            break;
                
            case 5:
                ViewBag.Titulo = "/images/habitacion5.png";
                ViewBag.Desc="Este diario… mi clave del banco estaba acá, en algún lado.";
                ViewBag.Img="/images/habitacion5.png";
                ViewBag.Pista1="Uní las letras como si fuesen las de un rompecabezas. ¡OJO! Algunas pueden sobrar, enfócate en un único color.";
                ViewBag.Pista2="Anagrama.";
                return View("Habitacion");
            break;
                
            default:
            break;
        }
        
        return View("Habitacion");
    }

    public IActionResult Habitacion (int sala, string clave)
    {
        sala=Escape.GetEstadoJuego();
        ViewBag.Sala = sala;

        if (sala==Escape.GetEstadoJuego()) //si está bien la sala
        {
            if (Escape.ResolverSala(sala, clave)==true) //si ganó
            {
                switch (Escape.GetEstadoJuego()) 
                {
                    case 2: 
                        ViewBag.Titulo = "Habitacion 2";
                        ViewBag.Desc="No puedo recordar mi nombre…";
                        ViewBag.Img="/images/habitacion2.png";
                        ViewBag.Pista1="Perdí mis anteojos, y sin ellos no puedo lograr leer mi nombre.";
                        ViewBag.Pista2="Soy una mujer.";
                        return View("Habitacion");
                        break;
                        
                    case 3:
                        ViewBag.Titulo = "Habitacion 3";
                        ViewBag.Desc="¿Cuál era el nombre de mi banco…?";
                        ViewBag.Img="/images/habitacion3.png";
                        ViewBag.Pista1="Están direcciones las dejé de ayuda memoria, pero no logro identificar cual pertenece al banco.";
                        ViewBag.Pista2="Si todavía no entendiste, fijate si alguna de estas coincide con un banco.";
                        return View("Habitacion3");
                        
                    break;
                        
                    case 4:
                        ViewBag.Titulo = "Habitacion 4";
                        ViewBag.Desc="No me acuerdo cuál de estos es mi documento.";
                        ViewBag.Img="/images/habitacion4.png";
                        ViewBag.Pista1="No me acuerdo cuál es mi documento, pero sí recuerdo que son mis hijos.";
                        ViewBag.Pista2="Las fechas de nacimiento te pueden resultar de gran ayuda.";
                        return View("Habitacion");
                    break;
                        
                    case 5:
                        ViewBag.Titulo = "/images/habitacion5.png";
                        ViewBag.Desc="Este diario… mi clave del banco estaba acá, en algún lado.";
                        ViewBag.Img="/images/habitacion5.png";
                        ViewBag.Pista1="Uní las letras como si fuesen las de un rompecabezas. ¡OJO! Algunas pueden sobrar, enfócate en un único color.";
                        ViewBag.Pista2="Anagrama.";
                        return View("Habitacion");
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
                    case 1: 
                        ViewBag.Titulo = "Habitacion 1";
                        ViewBag.Desc="Ay, ¿dónde dejé mi libreta?";
                        ViewBag.Img="/images/habitacion1.png";
                        ViewBag.Pista1="Buscá el código.";
                        ViewBag.Pista2="Está cerca de la computadora.";
                        return View("Habitacion1");
                        break;
                        
                    case 2: 
                        ViewBag.Titulo = "Habitacion 2";
                        ViewBag.Desc="No puedo recordar mi nombre…";
                        ViewBag.Img="/images/habitacion2.png";
                        ViewBag.Pista1="Perdí mis anteojos, y sin ellos no puedo lograr leer mi nombre.";
                        ViewBag.Pista2="Soy una mujer.";
                        return View("Habitacion");
                        break;
                        
                    case 3:
                        ViewBag.Titulo = "Habitacion 3";
                        ViewBag.Desc=" ¿Cuál era el nombre de mi banco…?";
                        ViewBag.Img="/images/habitacion3.png";
                        ViewBag.Pista1="Están direcciones las dejé de ayuda memoria, pero no logro identificar cual pertenece al banco.";
                        ViewBag.Pista2="Si todavía no entendiste, fijate si alguna de estas coincide con un banco.";
                        return View("Habitacion3");
                    break;
                        
                    case 4:
                        ViewBag.Titulo = "Habitacion 4";
                        ViewBag.Desc="No me acuerdo cuál de estos es mi documento.";
                        ViewBag.Img="/images/habitacion4.png";
                        ViewBag.Pista1="No me acuerdo cuál es mi documento, pero sí recuerdo que son mis hijos.";
                        ViewBag.Pista2="Las fechas de nacimiento te pueden resultar de gran ayuda.";
                        return View("Habitacion");
                    break;
                        
                    case 5:
                        ViewBag.Titulo = "/images/habitacion5.png";
                        ViewBag.Desc="Este diario… mi clave del banco estaba acá, en algún lado.";
                        ViewBag.Img="/images/habitacion5.png";
                        ViewBag.Pista1="Uní las letras como si fuesen las de un rompecabezas. ¡OJO! Algunas pueden sobrar, enfócate en un único color.";
                        ViewBag.Pista2="Anagrama.";
                        return View("Habitacion");
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
                    ViewBag.Img="/images/habitacion1.png";
                    ViewBag.Pista1="Buscá el código.";
                    ViewBag.Pista2="Está cerca de la computadora.";
                    return View("Habitacion1");
                    break;
                    
                case 2: 
                    ViewBag.Titulo = "Habitacion 2";
                    ViewBag.Desc="No puedo recordar mi nombre…";
                    ViewBag.Img="/images/habitacion2.png";
                    ViewBag.Pista1="Perdí mis anteojos, y sin ellos no puedo lograr leer mi nombre.";
                    ViewBag.Pista2="Soy una mujer.";
                    return View("Habitacion");
                    break;
                    
                case 3:
                    ViewBag.Titulo = "Habitacion 3";
                    ViewBag.Desc="¿Cuál era el nombre de mi banco…?";
                    ViewBag.Img="/images/habitacion3.png"; 
                    ViewBag.Pista1="Están direcciones las dejé de ayuda memoria, pero no logro identificar cual pertenece al banco.";
                    ViewBag.Pista2="Si todavía no entendiste, fijate si alguna de estas coincide con un banco.";
                    return View("Habitacion3");
                break;
                    
                case 4:
                    ViewBag.Titulo = "Habitacion 4";
                    ViewBag.Desc="No me acuerdo cuál de estos es mi documento.";
                    ViewBag.Img="/images/habitacion4.png";
                    ViewBag.Pista1="No me acuerdo cuál es mi documento, pero sí recuerdo que son mis hijos.";
                    ViewBag.Pista2="Las fechas de nacimiento te pueden resultar de gran ayuda.";
                    return View("Habitacion");
                break;
                    
                case 5:
                    ViewBag.Titulo = "Habitacion 5";
                    ViewBag.Desc="Este diario… mi clave del banco estaba acá, en algún lado.";
                    ViewBag.Img="/images/habitacion5.png"; 
                    ViewBag.Pista1="Uní las letras como si fuesen las de un rompecabezas. ¡OJO! Algunas pueden sobrar, enfócate en un único color.";
                    ViewBag.Pista2="Anagrama.";
                    return View("Habitacion");
                break;
                
                default: 
                break;
            }
        }


        return View("Habitacion");     
    }

}
