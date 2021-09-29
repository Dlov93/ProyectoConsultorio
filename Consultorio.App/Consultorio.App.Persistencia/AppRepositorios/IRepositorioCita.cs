using System.Collections.Generic;
using Consultorio.App.Dominio;
namespace Consultorio.App.Persistencia{
    
    public interface IRepositorioCita{
        IEnumerable<Cita> GetAllCita();
        Cita AddCita(Cita cita);
        Cita UpdateCita(Cita cita);
        void DeleteCita(string Documento);
        Cita GetCita(string Documento);
    }
    
                     
    }