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
    public class CrearHorarioMedicoModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        public Medico medico{get; set;}
        public CrearHorarioMedicoModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico = repositorioMedico;
        }
        public void OnGet(string Documento)
        {
            medico = repositorioMedico.GetMedico(Documento);
        }
        public IActionResult OnPost(Medico medico)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return Page();
                }

                repositorioMedico.AddHorario(medico);
                return RedirectToPage("./Medico");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
            
        }
    }
}