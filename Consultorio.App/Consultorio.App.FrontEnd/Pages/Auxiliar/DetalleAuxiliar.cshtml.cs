using System.Net;
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
    public class DetalleAuxiliarModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar auxiliar{get; set;}
        public DetalleAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet(string  Documento)
        {
            auxiliar= repositorioAuxiliar.GetAuxiliar(Documento);
        }
    }
}
