using Ejercicio1Unidad1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1Unidad1.Controllers
{
    public class HomeController : Controller
    {
        Datos datos = new Datos();
        public IActionResult Index()
        {
            datos.Nombre = "Jesus Alfonso Garza Perez";
            datos.Materia = "Programacion Web";
            datos.Periodo = "Agosto-Diciembre";
            datos.Semestre = 7;
            return View(datos);
        }

        public IActionResult MiPerfil()
        {
            datos.Nombre = "Jesus Alfonso Garza Perez";
            datos.Ciudad = "Sabinas";
            datos.Especialidad = "Sistemas";
            datos.Correo = "201G0256@rcarbonifera.tecnm.mx";
            datos.Telefono = "8110136426";
            datos.NumerodeControl = "201g0256";
            return View(datos);
        }

    }
}
