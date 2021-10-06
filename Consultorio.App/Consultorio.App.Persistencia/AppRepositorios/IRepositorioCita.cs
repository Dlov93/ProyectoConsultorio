using System.Collections.Generic;
using Consultorio.App.Dominio;
namespace Consultorio.App.Persistencia{
    
    public interface IRepositorioCita{
        IEnumerable<Cita> GetAllCita();
        //IEnumerable<Cliente> GetAllCliente();
        //IEnumerable<Medico> GetAllMedico();
        //IEnumerable<Auxiliar> GetAllAuxiliar();
        //IEnumerable <Horario> GetAllHorario();
        Cita AddCita(Cita cita);
        Cita UpdateCita(Cita cita);
        void DeleteCita(string Documento);
        Cita GetCita(string Documento);
    }
    
                     
    }