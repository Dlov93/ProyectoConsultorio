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
    public class DetalleClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public Cliente cliente{get; set;}
        public DetalleClienteModel(IRepositorioCliente repositorioCliente){
            this.repositorioCliente = repositorioCliente;
        }
        public void OnGet(string  Documento)
        {
            cliente= repositorioCliente.GetCliente(Documento);
        }
    }
}
