using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioHorario : IRepositorioHorario{
        private readonly AppContexto _appContext;
        
        public RepositorioHorario (AppContexto appContext){
            _appContext=appContext;
        }
        Horario IRepositorioHorario.AddHorario(Horario horario){
            var horarioAdicionado = _appContext.horario.Add(horario);
            _appContext.SaveChanges();
            return horarioAdicionado.Entity;
        }
        void IRepositorioHorario.DeleteHorario(string NameH){
            var HorarioEncontrado= _appContext.horario.FirstOrDefault(h => h.NameH==NameH);
            if(HorarioEncontrado==null){
            return;
            }
            _appContext.horario.Remove(HorarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Horario> IRepositorioHorario.GetAllHorario(){
            return _appContext.horario;
        }
        Horario IRepositorioHorario.GetHorario(string NameH){
            return _appContext.horario.FirstOrDefault(h => h.NameH==NameH);
        }
        Horario IRepositorioHorario.UpdateHorario(Horario horario){
            var horarioEncontrado=_appContext.horario.FirstOrDefault(h => h.NameH == horario.NameH);
            if(horarioEncontrado!=null){
                horarioEncontrado.FechaDisponible=horario.FechaDisponible;
                _appContext.SaveChanges();
            }
            return horarioEncontrado;

        }

    }
}