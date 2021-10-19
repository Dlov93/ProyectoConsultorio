using System.Collections.Generic;
using Consultorio.App.Dominio;
namespace Consultorio.App.Persistencia{
    
    public interface IRepositorioCita{
        IEnumerable<Cita> GetAllCitas();
        Cita AddCita(Cita cita);
        Cita UpdateCita(Cita cita);
        void DeleteCita(int ID);
        Cita GetCita(int ID);
    }
    
                     
    }