using System.Collections.Generic;
using Consultorio.App.Dominio;
namespace Consultorio.App.Persistencia{
    
    public interface IRepositorioAuxiliar{
        IEnumerable<Auxiliar> GetAllAuxiliar();
        Auxiliar AddAuxiliar(Auxiliar auxiliar);
        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);
        void DeleteAuxiliar(string Documento);
        Auxiliar GetAuxiliar(string Documento);

        
    }
    
        
    }