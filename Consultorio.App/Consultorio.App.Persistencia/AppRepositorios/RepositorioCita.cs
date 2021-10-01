using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioCita : IRepositorioCita{
        private readonly AppContexto _appContexto;
        
        public RepositorioCita(AppContexto appContexto){
            _appContexto=appContexto;
        }
        Cita IRepositorioCita.AddCita(Cita cita){
            var citaAdicionada= _appContexto.cita.Add(cita);
            _appContexto.SaveChanges();
            return citaAdicionada.Entity;
        }
        void IRepositorioCita.DeleteCita(string Documento){
            var citaEncontrada= _appContexto.cita.FirstOrDefault(ci => ci.cliente.Documento==Documento);
            if(citaEncontrada==null){
            return;
            }
            _appContexto.cita.Remove(citaEncontrada);
            _appContexto.SaveChanges();
        }
        IEnumerable<Cita> IRepositorioCita.GetAllCita(){
            return _appContexto.cita;
        }
        Cita IRepositorioCita.GetCita(string Documento){
            return _appContexto.cita.FirstOrDefault(ci => ci.cliente.Documento==Documento);
        }
        Cita IRepositorioCita.UpdateCita(Cita cita){
            var citaEncontrada=_appContexto.cita.FirstOrDefault(ci => ci.cliente.Documento==cita.cliente.Documento);
            if(citaEncontrada!=null){
                citaEncontrada.cliente=cita.cliente;
                citaEncontrada.medico=cita.medico;
                citaEncontrada.auxiliar=cita.auxiliar;
                //citaEncontrada.medico.Horario=cita.medico.Horario;
                _appContexto.SaveChanges();
            }
            return citaEncontrada;

        }

    }
}