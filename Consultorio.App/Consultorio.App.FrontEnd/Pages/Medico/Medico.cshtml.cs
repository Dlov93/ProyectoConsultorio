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
    public class MedicoModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        public IEnumerable<Medico> medicos;
        public MedicoModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico = repositorioMedico;
        }
        public void OnGet()
        {
            medicos = repositorioMedico.GetAllMedico();
        }
    }
}
