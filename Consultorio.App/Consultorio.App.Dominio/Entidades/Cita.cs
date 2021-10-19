using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Consultorio.App.Dominio{
    /*public class Cita{
        public int ID {get; set;}
        [Required]
        public Cliente cliente{get; set;}
        [Required]
        public Medico medico {get; set;}
        //[Required, DataType(DataType.DateTime)]
        //public Horario horario{get; set;}
        [Required]
        public Auxiliar auxiliar{get; set;}

    }*/

     public class Cita
    {
        [Key]
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        public Medico Medico { get; set; }
        public Auxiliar Auxiliar { get; set; }
        [Required,DataType(DataType.Date),Range(typeof(DateTime), "1/1/2021", "31/12/2025",
        ErrorMessage = "El valor {0} debe estar {1} y {2}")]
        public DateTime Dia { get; set; } = DateTime.Today;
        [Required,DataType(DataType.Time)]
        public DateTime Hora { get; set; } 
        public Sala Sala { get; set; }
        public string Descripcion { get; set; }
    }
}
