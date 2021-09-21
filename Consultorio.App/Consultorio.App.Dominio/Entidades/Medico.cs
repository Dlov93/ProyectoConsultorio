using System;
namespace Consultorio.App.Dominio{
    public class Medico:Persona{
        public string Especialidad { get; set; }
        /// Código único del médico
        public string Codigo { get; set; }
         /// Registro Unico Nacional del Talento Humano 
        public string RegistroRethus { get; set; }
        public Horario Horario{ get; set;}
    }

}