using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioCita : IRepositorioCita{
        private readonly AppContexto _appContexto;
        
        public RepositorioCita(AppContexto appContexto){
            _appContexto=appContexto;
        }
        public Cita AddCita(Cita cita){
            Cita citaAdicionada= _appContexto.Add(cita).Entity;
            _appContexto.SaveChanges();
            return citaAdicionada;
        }
         public void DeleteCita(string Documento){
            Cita citaEncontrada= _appContexto.cita.FirstOrDefault(ci => ci.cliente.Documento == Documento);
            if(citaEncontrada==null){
            return;
            }
            _appContexto.cita.Remove(citaEncontrada);
            _appContexto.SaveChanges();
        }
        public IEnumerable<Cita> GetAllCita(){
            return _appContexto.cita.Include("cliente").Include("medico")/*.Include("horario")*/.Include("auxiliar");
        }
        public Cita GetCita(string Documento){
            return  _appContexto.cita.Include("cliente").Include("medico")/*.Include("horario")*/.Include("auxiliar").FirstOrDefault(ci => ci.cliente.Documento == Documento);
            
        }
        public Cita UpdateCita(Cita cita){
            Cita citaEncontrada=_appContexto.cita.FirstOrDefault(ci => ci.ID==cita.ID);
            if(citaEncontrada!=null){
                citaEncontrada.cliente=cita.cliente;
                citaEncontrada.medico=cita.medico;
                citaEncontrada.auxiliar=cita.auxiliar;
                //citaEncontrada.horario=cita.horario;
                _appContexto.SaveChanges();
            }
            return citaEncontrada;

        }
        /*public IEnumerable<Horario> GetAllHorario(){
            return _appContexto.horario;
        }
        public IEnumerable<Medico> GetAllMedico(){
            return _appContexto.medico.Include("horario");
        }
        public IEnumerable<Cliente> GetAllCliente(){
            return _appContexto.cliente;
        }
        public IEnumerable<Auxiliar> GetAllAuxiliar(){
            return _appContexto.auxiliar;
        }*/

    }
}