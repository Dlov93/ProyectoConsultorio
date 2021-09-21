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
    public class ClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public IEnumerable<Cliente> clientes;
        public ClienteModel(IRepositorioCliente repositorioCliente){
            this.repositorioCliente =repositorioCliente;
        }
        public void OnGet()
        {
            clientes = repositorioCliente.GetAllCliente();
        }
    }
}
