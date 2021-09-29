using System.Collections.Generic;
using Consultorio.App.Dominio;
namespace Consultorio.App.Persistencia{
    
    public interface IRepositorioHorario{
        IEnumerable<Horario> GetAllHorario();
        Horario AddHorario(Horario horario);
        Horario UpdateHorario(Horario horario);
        void DeleteHorario(string NameH);
        Horario GetHorario(string NameH);
    }
    
        
    }