using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HolaMundoMVC.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View(new Alumno { Nombre = "Pepe", UniqueId = Guid.NewGuid().ToString() });
        }

        public IActionResult MultiAlumno()
        {
            var asignatura = new Alumno()
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };

            ViewBag.cosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            var listaAlumnos = new List<Alumno>()
            {
                new Alumno {Nombre="Roberto", UniqueId = Guid.NewGuid().ToString()},
                new Alumno {Nombre="Juan", UniqueId = Guid.NewGuid().ToString()},
                new Alumno {Nombre="Victor", UniqueId = Guid.NewGuid().ToString()},
                new Alumno {Nombre="Rebeca", UniqueId = Guid.NewGuid().ToString()}
            };

            var lAlumnos = GenerarAlumnosAlAzar();

            return View("MultiAlumno", lAlumnos);
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }

    }


}
