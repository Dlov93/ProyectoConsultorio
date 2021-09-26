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
    public class CrearAuxiliarModel : PageModel
    {
       private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar Auxiliar{get; set;}
        public CrearAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet()
        {
            Auxiliar= new Auxiliar();
        }
        public IActionResult OnPost(Auxiliar Auxiliar){
            repositorioAuxiliar.AddAuxiliar(Auxiliar);
            return RedirectToPage("./Auxiliar");
        }
    }
}
