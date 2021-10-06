using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Consultorio.App.Dominio;
using Consultorio.App.Persistencia;

namespace MyApp.Namespace
{
    public class MedicoModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioHorario repositorioHorario;
        public IEnumerable<Medico> medico {get; set;}
        public IEnumerable<Horario> horario {get; set;}
        //public Medico medico{get; set;}
        public Horario horarios {get; set;}
        public string NameH {get;set;}
        public MedicoModel(IRepositorioMedico repositorioMedico,IRepositorioHorario repositorioHorario)
        {
            this.repositorioMedico = repositorioMedico;
            this.repositorioHorario = repositorioHorario;
            horario = repositorioHorario.GetAllHorario();
        }
        public void OnGet()
        {
            medico = repositorioMedico.GetAllMedico();
        }
    }
}
