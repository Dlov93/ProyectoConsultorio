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
    public class EliminarAuxiliarModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar auxiliar {get; set;}
        public EliminarAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet(string Documento)
        {
            auxiliar=repositorioAuxiliar.GetAuxiliar(Documento);
        }
        public IActionResult OnPost(string Documento){
           
                repositorioAuxiliar.DeleteAuxiliar(Documento);
                return RedirectToPage("./Auxiliar");
            
        }
    }
}
