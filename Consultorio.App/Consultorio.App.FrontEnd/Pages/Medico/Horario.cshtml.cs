using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Consultorio.App.Persistencia;
using Consultorio.App.Dominio;

namespace Consultorio.App.FrontEnd.Pages
{
    public class HorarioModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        public IEnumerable<Medico> Medicos { get; set;}

        public HorarioModel(IRepositorioMedico repositorioMedico){
            this.repositorioMedico = repositorioMedico;
            Medicos = repositorioMedico.GetAllMedico();
        }
        public void OnGet()
        {
            
        }
    }
}