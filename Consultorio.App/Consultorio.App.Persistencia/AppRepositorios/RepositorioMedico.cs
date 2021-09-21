using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioMedico : IRepositorioMedico{
        private readonly AppContext _appContext;
        
        public RepositorioMedico(AppContext appContext){
            _appContext=appContext;
        }
        Medico IRepositorioMedico.AddMedico(Medico medico){
            var medicoAdicionado= _appContext.medico.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
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
                _appContext.SaveChanges();
            }
            return medicoEncontrado;

        }

    }
}