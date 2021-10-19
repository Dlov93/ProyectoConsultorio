using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Consultorio.App.Dominio{
    
    public class Horario{
        [Key]
        public int ID {get; set;}
        [Required]
        public DayOfWeek Dia { get; set; }
        [Required,DataType(DataType.Time)]
        public DateTime Hora_Inicio { get; set; }
        [Required,DataType(DataType.Time)]
        public DateTime Hora_Final { get; set; }
    }
}