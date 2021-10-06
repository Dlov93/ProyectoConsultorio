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
        public Horario AddHorario(Horario horario){
            Horario horarioAdicionado = _appContext.Add(horario).Entity;
            _appContext.SaveChanges();
            return horarioAdicionado;
        }
        public void DeleteHorario(string NameH){
            var HorarioEncontrado= _appContext.horario.FirstOrDefault(h => h.NameH==NameH);
            if(HorarioEncontrado==null){
            return;
            }
            _appContext.horario.Remove(HorarioEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Horario> GetAllHorario(){
            return _appContext.horario;
        }
        public Horario GetHorario(string NameH){
            return _appContext.horario.FirstOrDefault(h => h.NameH==NameH);
        }
        public Horario UpdateHorario(Horario horario){
            var horarioEncontrado=_appContext.horario.FirstOrDefault(h => h.NameH == horario.NameH);
            if(horarioEncontrado!=null){
                horarioEncontrado.FechaDisponible=horario.FechaDisponible;
                _appContext.SaveChanges();
            }
            return horarioEncontrado;

        }

    }
}