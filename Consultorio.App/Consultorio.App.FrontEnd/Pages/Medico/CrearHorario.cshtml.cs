using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Consultorio.App.Persistencia;
using Consultorio.App.Dominio;

namespace Consultorio.App.FrontEnd.Pages
{
    public class CrearHorarioModel : PageModel
    {
        private readonly IRepositorioHorario repositorioHorario;
        private readonly IRepositorioMedico repositorioMedico;
        public SelectList Medicos { get; set; }
        public Horario Horario { get; set; }
        public int CedulaMedico { get; set; }
        
        public CrearHorarioModel(IRepositorioMedico repositorioMedico,IRepositorioHorario repositorioHorario){
            this.repositorioMedico = repositorioMedico;
            this.repositorioHorario = repositorioHorario;
            Medicos = new SelectList(repositorioMedico.GetAllMedico(),nameof(Medico.Documento),nameof(Medico.Nombre));
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(Horario Horario,string CedulaMedico){
            Medico medico = repositorioMedico.GetMedico(CedulaMedico);
            if(ModelState.IsValid){
                Horario HorarioNuevo = repositorioHorario.AddHorario(Horario, medico.ID);
                if(HorarioNuevo != null){
                    return RedirectToPage("./Horario");
                }
                else{
                    ModelState.AddModelError(string.Empty,"El médico tiene un horario el mismo día");
                    return Page();
                }
            }
            else{
                return Page();
            }
        }
        
    }
}