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
    public class AgendarCitaModel : PageModel
    {
        private readonly IRepositorioCita repositorioCita;
        private readonly IRepositorioHorario repositorioHorario;
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        private readonly IRepositorioCliente repositorioCliente;
        public Cita cita{get; set;}
        public IEnumerable<Cita> citas {get; set;}
        public IEnumerable<Medico> medicos{get; set;}
        public IEnumerable<Horario> horarios {get; set;}
        public IEnumerable<Cliente> cliente {get; set;}
        public IEnumerable<Auxiliar> auxiliar {get; set;}
        public AgendarCitaModel(IRepositorioCita repositorioCita,IRepositorioCliente repositorioCliente, IRepositorioMedico repositorioMedico,IRepositorioHorario repositorioHorario,IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioCita = repositorioCita;
            this.repositorioCliente = repositorioCliente;
            this.repositorioMedico = repositorioMedico;
            this.repositorioHorario = repositorioHorario;
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet()
        {
            cita = new Cita();
        }
        public IActionResult OnPost(Cita cita){
            if(!ModelState.IsValid){
                return Page();
            }
            repositorioCita.AddCita(cita);
            return RedirectToPage("./CitasAgendadas");
        }
    }
}
