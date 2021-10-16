using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioHorario : IRepositorioHorario{
        private readonly AppContexto _appContext;
        
        public RepositorioHorario (AppContexto appContext){
            this._appContext = appContext;
        }
        public void AddHorario(Horario Horario, int IdMedico){
            Medico Medico = _appContext.medico.FirstOrDefault(m=>m.ID == IdMedico);

            List<Horario> horarios = Medico.Horarios;
            horarios.Add(Horario);
            Medico.Horarios = horarios;

            _appContext.SaveChanges();
        }

        public void DeleteHorario(int Id){
            Horario HorarioEncontrado= _appContext.horarios.FirstOrDefault(m => m.Id==Id);
            if(HorarioEncontrado==null){
            return;
            }
            _appContext.horarios.Remove(HorarioEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Horario> GetAllHorario(){
            return _appContext.horarios;
        }

        public Horario GetHorario(int Id){
            return _appContext.horarios.FirstOrDefault(m => m.Id==Id);
        }

        public Horario UpdateHorario(Horario horario){
            Horario HorarioEncontrado=_appContext.horarios.FirstOrDefault(m => m.Id==horario.Id);
            if(HorarioEncontrado!=null){
                HorarioEncontrado.Dia=horario.Dia;
                HorarioEncontrado.Hora_Inicio=horario.Hora_Inicio;
                HorarioEncontrado.Hora_Final = horario.Hora_Final;
                _appContext.SaveChanges();
            }
            return HorarioEncontrado;

        }

    }
}