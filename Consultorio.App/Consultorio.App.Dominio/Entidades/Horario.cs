using System;
using System.ComponentModel.DataAnnotations;

namespace Consultorio.App.Dominio{
    
    public class Horario{
        [Key]
        public int Id {get; set;}
        [Required,DataType(DataType.Date)]
        public Dia Dia { get; set; }
        [Required,DataType(DataType.Time)]
        public DateTime Hora_Inicio { get; set; }
        [Required,DataType(DataType.Time)]
        public DateTime Hora_Final { get; set; }
    }
}