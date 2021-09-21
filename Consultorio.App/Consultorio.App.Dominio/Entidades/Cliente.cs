using System;
namespace Consultorio.App.Dominio{
    public class Cliente:Persona{
        public string Ciudad {get;set;}
        public string Correo{get; set;}
        public string Direccion{get; set;}
        public DateTime FechaNacimiento{get; set;}
        
    }  
}