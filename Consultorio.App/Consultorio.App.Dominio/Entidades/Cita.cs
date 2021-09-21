using System;
namespace Consultorio.App.Dominio{
    public class Cita{
        public int ID {get; set;}
        public Cliente cliente{get; set;}
        public Medico medico {get; set;}
        //public Horario Horario{get; set;}
        public Auxiliar auxiliar{get; set;}

    }
}
