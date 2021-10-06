using System.Collections.Generic;
using Consultorio.App.Dominio;
namespace Consultorio.App.Persistencia{
    
    public interface IRepositorioMedico{
        IEnumerable<Medico> GetAllMedico();
        //IEnumerable<Horario> GetAllHorario();
        Medico AddMedico(Medico medico);
        Medico UpdateMedico(Medico medico);
        Medico AddHorario(Medico hora);
        void DeleteMedico(string Documento);
        Medico GetMedico(string Documento);
    }
    
        
    }