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
    public class CrearClienteModel : PageModel
    {
       private readonly IRepositorioCliente repositorioCliente;
        public Cliente cliente{get; set;}
        public CrearClienteModel(IRepositorioCliente repositorioCliente){
            this.repositorioCliente = repositorioCliente;
        }
        public void OnGet()
        {
            cliente= new Cliente();
        }
        public IActionResult OnPost(Cliente cliente){
            if(!ModelState.IsValid){
                return Page();
            }
            repositorioCliente.AddCliente(cliente);
            return RedirectToPage("./Cliente");
        }
    }
}
