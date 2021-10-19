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
        public Horario AddHorario(Horario Horario, int IdMedico){
            Medico Medico = _appContext.medico.FirstOrDefault(m=>m.ID == IdMedico);

            Medico Verificacion = _appContext.medico.FirstOrDefault(m => m.ID == IdMedico && m.Horario.Any(h => h.Dia == Horario.Dia));

            if (Verificacion == null)
            {
                List<Horario> horarios = Medico.Horario;
                horarios.Add(Horario);
                Medico.Horario = horarios;
                _appContext.SaveChanges();
                return Horario;
            }
            else
            {
                return null;
            }
        }

        public void DeleteHorario(int ID){
            Horario HorarioEncontrado= _appContext.horario.FirstOrDefault(m => m.ID==ID);
            if(HorarioEncontrado==null){
            return;
            }
            _appContext.horario.Remove(HorarioEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Horario> GetAllHorario(){
            return _appContext.horario;
        }

        public Horario GetHorario(int ID){
            return _appContext.horario.FirstOrDefault(m => m.ID==ID);
        }

        public Horario UpdateHorario(Horario horario){
            Horario HorarioEncontrado=_appContext.horario.FirstOrDefault(m => m.ID==horario.ID);
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