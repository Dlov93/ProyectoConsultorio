using System;
using System.ComponentModel.DataAnnotations;
namespace Consultorio.App.Dominio{
    public class Cita{
        public int ID {get; set;}
        [Required]
        public Cliente cliente{get; set;}
        [Required]
        public Medico medico {get; set;}
        [Required]
        //public Horario Horario{get; set;}
        public Auxiliar auxiliar{get; set;}

    }
}
