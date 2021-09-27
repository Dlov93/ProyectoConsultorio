using System;
using System.Collections.Generic;
using Consultorio.App.Dominio;
namespace Consultorio.App.Persistencia{
    
    public interface IRepositorioHorario{
        IEnumerable<Horario> GetAllHorario();
        Horario AddHorario(Horario horario);
        Horario UpdateHorario(Horario horario);
        void DeleteHorario(DateTime fecha);
        Horario GetHorario(DateTime fecha);
    }
    
        
    }