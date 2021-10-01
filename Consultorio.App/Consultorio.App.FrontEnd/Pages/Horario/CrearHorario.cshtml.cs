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
    public class CrearHorarioModel : PageModel
    {
        private readonly IRepositorioHorario repositorioHorario;
        public Horario horario{get; set;}
        public CrearHorarioModel(IRepositorioHorario repositorioHorario)
        {
            this.repositorioHorario = repositorioHorario;
        }
        public void OnGet()
        {
            horario = new Horario();
        }

        public IActionResult OnPost(Horario horario)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            
            try
            {
                repositorioHorario.AddHorario(horario);
                return RedirectToPage("./Horario");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
            
        }
    }
}