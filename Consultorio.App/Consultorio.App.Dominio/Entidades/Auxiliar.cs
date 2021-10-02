using System;
using System.ComponentModel.DataAnnotations;
namespace Consultorio.App.Dominio{
    public class Auxiliar:Persona{
       [Required(ErrorMessage="El campo es obligatorio")]
     // [Display(Name = "Ingrese ")]
        public string CodigoA{get; set;}
     
             

    }
}