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
        public class AuxiliarModel : PageModel
    
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public IEnumerable<Auxiliar> auxiliar{get; set;}
        public AuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioAuxiliar =repositorioAuxiliar;
            
        }
        public void OnGet()
        {
            auxiliar = repositorioAuxiliar.GetAllAuxiliar();
        }
    }
}