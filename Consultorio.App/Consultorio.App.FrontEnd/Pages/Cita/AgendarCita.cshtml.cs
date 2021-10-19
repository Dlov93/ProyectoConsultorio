using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Consultorio.App.Persistencia;
using Consultorio.App.Dominio;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyApp.Namespace
{
    public class AgendarCitaModel : PageModel
    {
        private readonly IRepositorioCita repositorioCita;
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        private readonly IRepositorioCliente repositorioCliente;
        //private readonly IRepositorioHorario repositorioHorario;

        public SelectList medicos{get; set;}
        public SelectList auxiliares { get; set; }
        public SelectList clientes { get; set; }
        
        //public string Documento{get; set;}
        //public Medico medico{get; set;}
        //public Horario horario{get; set;}
        //public Auxiliar auxiliares{get; set;}

        //public IEnumerable<Cita> Citas {get; set;}
        //public IEnumerable<SelectListItem> medicos{get; set;}
        //public IEnumerable<SelectListItem> horarios {get; set;}
        //public IEnumerable<SelectListItem> clientes {get; set;}
        //public SelectListItem cliente {get; set;}
        //public IEnumerable<SelectListItem> auxiliares {get; set;}

        public string cedulaMedico{get; set;}
        public string cedulaCliente{get; set;}
        public string cedulaAuxiliar{get; set;}
        public Cita Cita{get; set;}
        public string Mensaje { get; set; }

        
        public AgendarCitaModel(IRepositorioCita repositorioCita,IRepositorioCliente repositorioCliente, IRepositorioMedico repositorioMedico, IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioCita = repositorioCita;
            this.repositorioCliente = repositorioCliente;
            this.repositorioMedico = repositorioMedico;
            this.repositorioAuxiliar = repositorioAuxiliar;

           //cliente = new SelectListItem(repositorioCliente.GetAllCliente());
           //cliente = repositorioCliente.GetAllCliente();
           

           medicos = new SelectList(repositorioMedico.GetAllMedico(),nameof(Medico.Documento),nameof(Medico.NombreCompleto));
           clientes = new SelectList(repositorioCliente.GetAllCliente(),nameof(Cliente.Documento),nameof(Cliente.NombreCompleto));
           auxiliares = new SelectList(repositorioAuxiliar.GetAllAuxiliar(),nameof(Auxiliar.Documento),nameof(Auxiliar.NombreCompleto));
           Cita = new Cita();


        }
        public void OnGet()
        {
            
        }
        
        public IActionResult OnPost(Cita Cita, string cedulaMedico, string cedulaCliente, string cedulaAuxiliar)
        {
            Medico medico = repositorioMedico.GetMedico(cedulaMedico);
            Cliente cliente = repositorioCliente.GetCliente(cedulaCliente);
            Auxiliar auxiliar = repositorioAuxiliar.GetAuxiliar(cedulaAuxiliar);

            Cita nuevaCita = new Cita(){
                Medico = medico,
                Cliente = cliente,
                Auxiliar = auxiliar,
                Hora = Cita.Hora,
                Dia = Cita.Dia,
                Descripcion = Cita.Descripcion,
                Sala = Cita.Sala,
            };

            if(ModelState.IsValid){

                Cita citaInsertada = repositorioCita.AddCita(nuevaCita);
                if (citaInsertada!=null){
                    return RedirectToPage("./CitasAgendadas");
                }
                else{
                    Mensaje = "El medico tiene una cita a esa hora o la sala está ocupada en ese momento";
                    return Page();
                }                
                
            }
            else {
                return Page();
            }
        }
    }
}
