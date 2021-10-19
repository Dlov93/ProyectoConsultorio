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
            /*Cita citaAdicionada= _appContexto.Add(cita).Entity;
            _appContexto.SaveChanges();
            return citaAdicionada;*/

            /*
            1) El medico no debe tener una cita entre la hora de cita y 30 minutos después
            2) Una sala no puede tener una cita al mismo tiempo
            3) Un cliente no puede tener dos citas al mismo tiempo
            */
            Cita citaCruzada = _appContexto.cita.FirstOrDefault(
                c => c.Medico.ID == cita.Medico.ID &&
                cita.Dia == c.Dia &&
                cita.Hora >= c.Hora &&
                cita.Hora < c.Hora.AddMinutes(30)                
                );

            Cita citaEspacio = _appContexto.cita.FirstOrDefault(
                c => c.Sala == cita.Sala &&
                cita.Dia == c.Dia &&
                cita.Hora >= c.Hora &&
                cita.Hora < c.Hora.AddMinutes(30)                
                );

            Cita citaCliente = _appContexto.cita.FirstOrDefault(
                c => c.Cliente.ID == cita.Cliente.ID &&
                cita.Dia == c.Dia &&
                cita.Hora >= c.Hora &&
                cita.Hora < c.Hora.AddMinutes(30)                
                );

            //Es consultar si el médico tiene disponibilidad en la hora la cita
            int hora_cita = cita.Hora.Hour;
            int cita_minuto = cita.Hora.Minute;

            Medico Medico = _appContexto.medico.FirstOrDefault(
                m => m.ID == cita.Medico.ID && 
                m.Horario.Any(h =>h.Dia == cita.Dia.DayOfWeek &&
                        hora_cita >= h.Hora_Inicio.Hour &&
                        cita_minuto >= h.Hora_Inicio.Minute &&
                        hora_cita <= h.Hora_Final.AddMinutes(-30).Hour &&
                        cita_minuto <= h.Hora_Final.AddMinutes(-30).Minute
                    )
            );

            if(citaEspacio == null && citaCruzada == null && citaCliente == null && Medico!=null && cita.Dia >= DateTime.Now){
                Cita nuevaCita = _appContexto.Add(cita).Entity;
                _appContexto.SaveChanges();
                return nuevaCita;
            }
            else{
                return null;
            }
        }
         public void DeleteCita(int ID){
            Cita citaEncontrada= _appContexto.cita.FirstOrDefault(ci => ci.ID == ID);
            if(citaEncontrada==null){
            return;
            }
            _appContexto.cita.Remove(citaEncontrada);
            _appContexto.SaveChanges();
        }
        public IEnumerable<Cita> GetAllCitas(){
            return _appContexto.cita.Include("Medico").Include("Cliente");
        }
        public Cita GetCita(int ID){
            return  _appContexto.cita.Include("Medico").Include("Cliente")/*.Include("horario").Include("auxiliar")*/.FirstOrDefault(ci => ci.ID == ID);
            
        }
        public Cita UpdateCita(Cita cita){
            Cita citaEncontrada=_appContexto.cita.FirstOrDefault(ci => ci.ID==cita.ID);
            if(citaEncontrada!=null){
                citaEncontrada.Cliente=cita.Cliente;
                citaEncontrada.Medico=cita.Medico;
                citaEncontrada.Auxiliar=cita.Auxiliar;
                //citaEncontrada.Horario=cita.horario;
                _appContexto.SaveChanges();
            }
            return citaEncontrada;

        }
        
    }
}