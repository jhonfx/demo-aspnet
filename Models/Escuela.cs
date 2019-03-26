using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace HolaMundoMVC.Models
{
    public class Escuela : ObjetoEscuelaBase
    {
        public string escuelaId { get; set; }
        public string nombreEscuela { get; set; }
        public string anioFundacion { get; set; }
        public string pais { get; set; }
        public string ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public void Configure(IApplicationBuilder app)
        {
           
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {pais}, Ciudad: {ciudad}";
        }
    }
}
