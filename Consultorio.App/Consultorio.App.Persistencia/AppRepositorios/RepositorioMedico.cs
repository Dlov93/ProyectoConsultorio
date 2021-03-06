using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;
using Microsoft.EntityFrameworkCore;


namespace Consultorio.App.Persistencia{
    
    public class RepositorioMedico : IRepositorioMedico{
        private readonly AppContexto _appContext;
        private readonly Security security;
        
        public RepositorioMedico(AppContexto appContext){
            _appContext=appContext;
            security = new Security();
        }
        public Medico AddMedico(Medico medico){
            medico.Contraseña = security.GetMD5Hash(medico.Contraseña);
            Medico medicoAdicionado= _appContext.Add(medico).Entity;

            medico.Horario = new List<Horario>();
            _appContext.SaveChanges();
            return medicoAdicionado;
        }
        public void DeleteMedico(string Documento){
            Medico medicoEncontrado= _appContext.medico.FirstOrDefault(m => m.Documento==Documento);
            if(medicoEncontrado==null){
            return;
            }
            _appContext.medico.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Medico> GetAllMedico(){
            return _appContext.medico.Include("Horario");
        }
        public Medico GetMedico(string Documento){
            return _appContext.medico.Include("Horario").FirstOrDefault(m => m.Documento==Documento);
        }
        public Medico UpdateMedico(Medico medico){
            medico.Contraseña = security.GetMD5Hash(medico.Contraseña);
            Medico medicoEncontrado=_appContext.medico.FirstOrDefault(m => m.Documento==medico.Documento);
            if(medicoEncontrado!=null){
                medicoEncontrado.Nombre=medico.Nombre;
                medicoEncontrado.Apellido=medico.Apellido;
                medicoEncontrado.Genero = medico.Genero;
                medicoEncontrado.Telefono=medico.Telefono;
                medicoEncontrado.Codigo= medico.Codigo;
                medicoEncontrado.RegistroRethus = medico.RegistroRethus ;
                medicoEncontrado.UserName= medico.UserName;
                medicoEncontrado.Correo= medico.Correo;
                medicoEncontrado.Contraseña=medico.Contraseña;
                _appContext.SaveChanges();
            }
            return medicoEncontrado;

        }

    }
}