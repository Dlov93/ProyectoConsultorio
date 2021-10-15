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
    
    public class EliminarCitaModel : PageModel
    {
        private readonly IRepositorioCita repositorioCita;
        public Cita cita{get; set;}
        public int ID {get; set;}
        public EliminarCitaModel(IRepositorioCita repositorioCita){
            this.repositorioCita = repositorioCita;
        }
        public void OnGet()
        {
            cita =repositorioCita.GetCita(ID);
            Console.WriteLine(ID);
            repositorioCita.DeleteCita(ID);
        }
        public IActionResult OnPost(int ID){
                             
                repositorioCita.DeleteCita(ID);
                return RedirectToPage("./CitasAgendadas");
               // Console.WriteLine(ID);
           
           
                return RedirectToPage("../Error");
            
        }
    }
}
