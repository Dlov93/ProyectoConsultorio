using System.Xml.Linq;
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
    public class verHorariosModel : PageModel
    {
        private readonly IRepositorioHorario repositorioHorario;
        public IEnumerable<Horario> horario;
        public verHorariosModel(IRepositorioHorario repositorioHorario){
            this.repositorioHorario = repositorioHorario;
        }
        public void OnGet()
        {
            horario = repositorioHorario.GetAllHorario();
        }
    }
}
