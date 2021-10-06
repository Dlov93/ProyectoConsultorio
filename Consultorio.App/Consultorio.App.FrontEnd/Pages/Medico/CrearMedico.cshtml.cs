using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Consultorio.App.Dominio;
using Consultorio.App.Persistencia;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyApp.Namespace
{
    public class CrearMedicoModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioHorario repositorioHorario;
        public Medico medico{get; set;}
        public Horario horario {get; set;}
        public IEnumerable<SelectListItem> medicos {get; set;}
        public IEnumerable<SelectListItem> horarios {get; set;} 
        public CrearMedicoModel(IRepositorioMedico repositorioMedico,IRepositorioHorario repositorioHorario)
        {
            this.repositorioMedico = repositorioMedico;
            this.repositorioHorario = repositorioHorario;
        }
        public void OnGet()
        {
            medico = new Medico();
            //horarios = repositorioHorario.GetAllHorario();
        }

        public IActionResult OnPost(Medico medico)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return Page();
                }
                
                repositorioMedico.AddMedico(medico);
                return RedirectToPage("./Medico");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
            
        }
    }
}
