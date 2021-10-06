using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;
using System.Security.Cryptography;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioMedico : IRepositorioMedico{
        private readonly AppContexto _appContext;
        private readonly Security security;
        
        public RepositorioMedico(AppContexto appContext){
            _appContext=appContext;
            security =new Security();
        }
        Medico IRepositorioMedico.AddMedico(Medico medico){
            string contraseña = medico.Contraseña;
            contraseña += "claxo"+contraseña.Reverse();
            contraseña = security.GetMD5Hash(contraseña);
            medico.Contraseña = contraseña;
            var medicoAdicionado= _appContext.medico.Add(medico).Entity;
            _appContext.SaveChanges();
            return medicoAdicionado;
        }
        void IRepositorioMedico.DeleteMedico(string Documento){
            var medicoEncontrado= _appContext.medico.FirstOrDefault(m => m.Documento==Documento);
            if(medicoEncontrado==null){
            return;
            }
            _appContext.medico.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Medico> IRepositorioMedico.GetAllMedico(){
            return _appContext.medico;
        }
        Medico IRepositorioMedico.GetMedico(string Documento){
            return _appContext.medico.FirstOrDefault(c => c.Documento==Documento);
        }
        Medico IRepositorioMedico.UpdateMedico(Medico medico){
            var medicoEncontrado=_appContext.medico.FirstOrDefault(m => m.Documento==medico.Documento);
            if(medicoEncontrado!=null){
                medicoEncontrado.Nombre=medico.Nombre;
                medicoEncontrado.Apellido=medico.Apellido;
                medicoEncontrado.Genero = medico.Genero;
                medicoEncontrado.Telefono=medico.Telefono;
                medicoEncontrado.Codigo= medico.Codigo;
                medicoEncontrado.RegistroRethus = medico.RegistroRethus ;
                medicoEncontrado.Horario= medico.Horario;
                medicoEncontrado.UserName= medico.UserName;
                medicoEncontrado.Correo= medico.Correo;
                medicoEncontrado.Contraseña=medico.Contraseña;
                _appContext.SaveChanges();
            }
            return medicoEncontrado;

        }

        Medico IRepositorioMedico.AddHorario(Medico hora){
            var medicoEncontrado=_appContext.medico.FirstOrDefault(m => m.Documento==hora.Documento);
            if(medicoEncontrado!=null){
                // medicoEncontrado.Nombre=medico.Nombre;
                // medicoEncontrado.Apellido=medico.Apellido;
                // medicoEncontrado.Genero = medico.Genero;
                // medicoEncontrado.Telefono=medico.Telefono;
                // medicoEncontrado.Codigo= medico.Codigo;
                // medicoEncontrado.RegistroRethus = medico.RegistroRethus ;
                // medicoEncontrado.UserName= medico.UserName;
                // medicoEncontrado.Correo= medico.Correo;
                // medicoEncontrado.Contraseña=medico.Contraseña;
                medicoEncontrado.Horario= hora.Horario;
                _appContext.SaveChanges();
            }
            return medicoEncontrado;

        }

    }
}