using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Consultorio.App.Persistencia;
using Consultorio.App.Dominio;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyApp.Namespace
{
    public class AgendarCitaModel : PageModel
    {
        private readonly IRepositorioCita repositorioCita;
        private readonly IRepositorioHorario repositorioHorario;
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        private readonly IRepositorioCliente repositorioCliente;
        //public Cita Citas{get; set;}
        public string Documento{get; set;}
        public Medico medico{get; set;}
        public Horario horario{get; set;}
        public Auxiliar auxiliares{get; set;}

        public IEnumerable<Cita> Citas {get; set;}
        public IEnumerable<SelectListItem> medicos{get; set;}
        public IEnumerable<SelectListItem> horarios {get; set;}
        public IEnumerable<Cliente> cliente {get; set;}
        //public SelectListItem cliente {get; set;}
        public IEnumerable<SelectListItem> auxiliar {get; set;}
        
        public AgendarCitaModel(IRepositorioCita repositorioCita,IRepositorioCliente repositorioCliente, IRepositorioMedico repositorioMedico,IRepositorioHorario repositorioHorario,IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioCita = repositorioCita;
            this.repositorioCliente = repositorioCliente;
            this.repositorioMedico = repositorioMedico;
            this.repositorioHorario = repositorioHorario;
            this.repositorioAuxiliar = repositorioAuxiliar;

           //cliente = new SelectListItem(repositorioCliente.GetAllCliente());
           //cliente = repositorioCliente.GetAllCliente();
        }
        public void OnGet()
        {
            Citas= repositorioCita.GetAllCita();
           cliente = repositorioCliente.GetAllCliente();
            //cita = new Cita();
           /*cliente = repositorioCliente.GetCliente().Select(
                c => new SelectListItem(
                    text=c.Nombre+""+ c.Documento,
                    value = c.Documento
                )
            ).toList();*/
        }
        /*public IActionResult OnPost(Cita cita){
            if(!ModelState.IsValid){
                return Page();
            }
            repositorioCita.AddCita(cita);
            return RedirectToPage("./CitasAgendadas");
        }*/
    }
}
