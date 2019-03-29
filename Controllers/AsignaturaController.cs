using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HolaMundoMVC.Controllers
{
    public class AsignaturaController : Controller
    {
        // GET: /<controller>/

        
        public IActionResult Index()
        {

            return View(new Asignatura { Nombre = "Quimica", UniqueId = Guid.NewGuid().ToString() });
        }

        public IActionResult MultiAsignatura()
        {
            var asignatura = new Asignatura()
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };

            ViewBag.cosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            var listaAsignaturas = new List<Asignatura>()
            {
                new Asignatura {Nombre="Matemáticas", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura {Nombre="Geografía", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura {Nombre="Ciencias Sociales", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura {Nombre="Informática", UniqueId = Guid.NewGuid().ToString()}
            };

            return View("MultiAsignatura", listaAsignaturas);
        }

    }
}
