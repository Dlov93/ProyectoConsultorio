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
        private readonly IRepositorioCliente repositorioCliente;
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioHorario repositorioHorario;
        private readonly IRepositorioAuxiliar repositorioAuxiliar;

        public SelectList cliente {get; set;}
        public SelectList medico  {get; set;}
        public SelectList horario {get; set;}
        public SelectList auxiliar {get; set;}
        public IEnumerable<Cita> citas;

        public string Documento{get; set;}
        public int ID{get; set;}


        public CitasAgendadasModel(IRepositorioCita repositorioCita,IRepositorioAuxiliar repositorioAuxiliar,IRepositorioHorario repositorioHorario,IRepositorioMedico repositorioMedico,IRepositorioCliente repositorioCliente){
            
            this.repositorioCita=repositorioCita;
            this.repositorioCliente = repositorioCliente;
            this.repositorioMedico = repositorioMedico;
            this.repositorioAuxiliar = repositorioAuxiliar;
            this.repositorioHorario = repositorioHorario;

            cliente = new SelectList(repositorioCliente.GetAllCliente(),nameof(Cliente.Documento));
            medico = new SelectList(repositorioMedico.GetAllMedico(),nameof(Medico.Documento));
            horario = new SelectList(repositorioHorario.GetAllHorario(),nameof(Horario.ID));
            auxiliar = new SelectList(repositorioAuxiliar.GetAllAuxiliar(),nameof(Auxiliar.Documento));
        }
        public void OnGet()
        {
            //citas = repositorioCita.GetAllCita();
            
        }
    }
}
