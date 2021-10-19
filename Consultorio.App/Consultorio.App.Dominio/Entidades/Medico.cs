using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Consultorio.App.Dominio{
    public class Medico:Persona{
        [Required(ErrorMessage="Especialidad es requerida"), StringLength(50,MinimumLength=5,ErrorMessage="Por favor digite una especialidad médica válida")]
        public string Especialidad { get; set; }        
        /// Código único del médico
        [Required, StringLength(20,MinimumLength=5,ErrorMessage="Por favor digite un código")]
        public string Codigo { get; set; }
         [Required(ErrorMessage="Registro Rethus es requerido"), StringLength(20,MinimumLength=5,ErrorMessage="Por favor digite su Registro Rethus")]
         /// Registro Unico Nacional del Talento Humano 
        public string RegistroRethus { get; set; }        
        public List<Horario> Horario { get; set; }

    }

}