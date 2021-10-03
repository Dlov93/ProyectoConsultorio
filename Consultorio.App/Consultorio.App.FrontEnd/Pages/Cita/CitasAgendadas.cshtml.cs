using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Consultorio.App.Persistencia;
using Consultorio.App.Dominio;

namespace MyApp.Namespace
{
    public class CitasAgendadasModel : PageModel
    {
        private readonly IRepositorioCita repositorioCita;
        public IEnumerable<Cita> citas;
        public CitasAgendadasModel(IRepositorioCita repositorioCita){
            this.repositorioCita=repositorioCita;
        }
        public void OnGet()
        {
            citas = repositorioCita.GetAllCita();
            
        }
    }
}
