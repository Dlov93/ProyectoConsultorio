using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Consultorio.App.Dominio{
    public class Cita{
        public int ID {get; set;}
        [Required]
        public Cliente cliente{get; set;}
        [Required]
        public Medico medico {get; set;}
        //[Required, DataType(DataType.DateTime)]
        //public Horario horario{get; set;}
        [Required]
        public Auxiliar auxiliar{get; set;}

    }
}
