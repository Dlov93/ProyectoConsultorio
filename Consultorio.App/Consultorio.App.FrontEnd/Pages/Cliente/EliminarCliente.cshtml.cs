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
    public class EliminarClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public Cliente cliente{get; set;}
        public EliminarClienteModel(IRepositorioCliente repositorioCliente) 
        {
            this.repositorioCliente = repositorioCliente;               
        }
        public void OnGet(string Documento)
        {
            //this.Documento = Documento;
            cliente=repositorioCliente.GetCliente(Documento);
            Console.WriteLine(Documento);
        }
        public IActionResult OnPost(string Documento){
             Console.WriteLine(Documento);
           try{
                Console.WriteLine(Documento);
                repositorioCliente.DeleteCliente(Documento);
                return RedirectToPage("./Cliente");
           }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
