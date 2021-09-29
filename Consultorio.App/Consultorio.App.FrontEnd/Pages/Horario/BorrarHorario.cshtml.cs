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
    public class BorrarHorarioModel : PageModel
    {
        private readonly IRepositorioHorario repositorioHorario;
        public Horario horario{get; set;}
        public BorrarHorarioModel(IRepositorioHorario repositorioHorario)
        {
            this.repositorioHorario = repositorioHorario;
        }
        public void OnGet(string NameH)
        {
            horario = repositorioHorario.GetHorario(NameH);
        }
        public IActionResult OnPost(string NameH)
        {
            repositorioHorario.DeleteHorario(NameH);
            return RedirectToPage("./Horario");
        }
    }
}