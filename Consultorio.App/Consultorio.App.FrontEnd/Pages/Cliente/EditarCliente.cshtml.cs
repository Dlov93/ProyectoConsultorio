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
    public class EditarClienteModel : PageModel
    { private readonly IRepositorioCliente repositorioCliente;
        public Cliente cliente{get; set;}
        public EditarClienteModel(IRepositorioCliente repositorioCliente){
            this.repositorioCliente = repositorioCliente;
        }
        public void OnGet(string  Documento)
        {
            cliente= repositorioCliente.GetCliente(Documento);
        }
        public IActionResult OnPost(Cliente cliente){
            if(!ModelState.IsValid){
                return Page();
            }
            repositorioCliente.UpdateCliente(cliente);
            return RedirectToPage("./Cliente");

        }
    }
}
