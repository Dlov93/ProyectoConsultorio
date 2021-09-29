using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Consultorio.App.Dominio;
using Consultorio.App.Persistencia;

namespace MyApp.Namespace
{
    public class HorarioModel : PageModel
    {
        private readonly IRepositorioHorario repositorioHorario;
        public IEnumerable<Horario> horarios;
        public HorarioModel(IRepositorioHorario repositorioHorario){
            this.repositorioHorario =repositorioHorario;
        }
        public void OnGet()
        {
            horarios = repositorioHorario.GetAllHorario();
        }
    }
}