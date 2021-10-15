using System.Collections.Generic;
using Consultorio.App.Dominio;
namespace Consultorio.App.Persistencia{
    
    public interface IRepositorioHorario{
        IEnumerable<Horario> GetAllHorario();
        void AddHorario(Horario Horario, int IdMedico);
        Horario UpdateHorario(Horario horario);
        void DeleteHorario(int Id);
        Horario GetHorario(int Id);
    }

}