using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Consultorio.App.Persistencia;
using Consultorio.App.Dominio;

namespace MyApp.Namespace
{
    public class CitasAgendadasModel : PageModel
    {             
        private readonly IRepositorioCita repositorioCita;
        public IEnumerable<Cita> citas{get; set;}

        public CitasAgendadasModel(IRepositorioCita repositorioCita)
        {
            this.repositorioCita = repositorioCita;
            citas = repositorioCita.GetAllCitas();
        }
                
        public void OnGet()
        {
            
        }
    }
}
