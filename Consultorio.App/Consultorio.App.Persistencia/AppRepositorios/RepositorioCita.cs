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
                citaEncontrada.cliente.Nombre=cita.cliente.Nombre;
                citaEncontrada.cliente.Apellido=cita.cliente.Apellido;
                citaEncontrada.cliente.Genero = cita.cliente.Genero;
                citaEncontrada.cliente.Telefono=cita.cliente.Telefono;
                citaEncontrada.cliente.Ciudad= cita.cliente.Ciudad;
                citaEncontrada.cliente.Direccion= cita.cliente.Direccion;
                citaEncontrada.cliente.Correo= cita.cliente.Correo;
                citaEncontrada.cliente.FechaNacimiento= cita.cliente.FechaNacimiento;
                citaEncontrada.medico.Nombre=cita.medico.Nombre;
                citaEncontrada.medico.Apellido=cita.medico.Apellido;
                citaEncontrada.medico.Genero = cita.medico.Genero;
                citaEncontrada.medico.Telefono=cita.medico.Telefono;
                citaEncontrada.medico.Codigo= cita.medico.Codigo;
                citaEncontrada.medico.RegistroRethus = cita.medico.RegistroRethus ;
                citaEncontrada.medico.Horario= cita.medico.Horario;
                citaEncontrada.auxiliar.Nombre=cita.auxiliar.Nombre;
                citaEncontrada.auxiliar.Apellido=cita.auxiliar.Apellido;
                citaEncontrada.auxiliar.Genero = cita.auxiliar.Genero;
                citaEncontrada.auxiliar.Telefono=cita.auxiliar.Telefono;
                citaEncontrada.auxiliar.CodigoA= cita.auxiliar.CodigoA;
                _appContexto.SaveChanges();
            }
            return citaEncontrada;

        }

    }
}