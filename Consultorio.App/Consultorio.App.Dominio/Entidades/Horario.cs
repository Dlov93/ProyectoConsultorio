using System;
using System.ComponentModel.DataAnnotations;
//using Consultorio.App.Persistencia;

namespace Consultorio.App.Dominio{
    
    public class Horario{
        public int ID {get; set;}

        //[NameHExistAttribute(ErrorMessage = "El nombre ya existe")]
        [Required(ErrorMessage = "El campo es obligatorio"),Display(Name="Ingrese un nombre para su horario")]
        public string NameH {get; set;}
        [Required, DataType(DataType.DateTime),Display(Name="Ingresa el horario")]
        public DateTime FechaDisponible {get;set;}
    }

    // public class NameHExistAttribute : ValidationAttribute
    // {
    //     public override bool IsValid(Object value)
    //     {
            
    //         if(DataBase.Contains(value))
    //         if(_appContext.horario.FirstOrDefault(h.NameH == value))
    //         {
    //             return false;
    //         }
    //             return true;
    //         return base.IsValid(NameH);
        
    //     }
    // }
}