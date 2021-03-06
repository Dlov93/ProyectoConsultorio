using System;
using System.ComponentModel.DataAnnotations;
namespace Consultorio.App.Dominio{
    public class Cliente:Persona{

        [Required, StringLength(50)]
        public string Ciudad {get;set;}
        [Required, StringLength(50)]
        public string Direccion{get; set;}
        [Required, DataType(DataType.DateTime)]
        public DateTime FechaNacimiento{get; set;}
        
    }  
}