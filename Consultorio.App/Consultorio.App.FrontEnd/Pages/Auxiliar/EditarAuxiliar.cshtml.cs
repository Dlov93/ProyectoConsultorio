using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Consultorio.App.Persistencia;
using Consultorio.App.Dominio;
//using Consultorio.App.Dominio.Entidades.Auxiliar;

namespace MyApp.Namespace
{
    public class EditarAuxiliarModel : PageModel
    
    { private readonly IRepositorioAuxiliar RepositorioAuxiliar;
    
        public Auxiliar Auxiliar{get; set;}
      
        public EditarAuxiliarModel(IRepositorioAuxiliar RepositorioAuxiliar){
            this.RepositorioAuxiliar = RepositorioAuxiliar;
        }
        public void OnGet(string  Documento)
        {
            Auxiliar= RepositorioAuxiliar.GetAuxiliar(Documento);
        }
        public IActionResult OnPost(Auxiliar Auxiliar){
            RepositorioAuxiliar.UpdateAuxiliar(Auxiliar);
            return RedirectToPage("./Auxiliar");

        }
    }
}