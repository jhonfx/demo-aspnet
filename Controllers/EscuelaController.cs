using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers
{
    public class EscuelaController : Controller
    {

        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.escuelaId = "13567";
            escuela.nombreEscuela = "Vasconcelos";
            escuela.anioFundacion = Guid.NewGuid().ToString();
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            var alumnos = new List<String>();
            alumnos.Add("Juan");
            alumnos.Add("Maleni");
            alumnos.Add("Ximena");
            alumnos.Add("Renata");

            ViewBag.cosaDinamica = alumnos;
            return View(escuela);
        }

        public void Configure(IApplicationBuilder app)
        {
        
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
