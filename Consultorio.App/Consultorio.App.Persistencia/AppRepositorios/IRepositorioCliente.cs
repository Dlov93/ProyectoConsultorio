using System.Collections.Generic;
using Consultorio.App.Dominio;
namespace Consultorio.App.Persistencia{
    
    public interface IRepositorioCliente{
        IEnumerable<Cliente> GetAllCliente();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(string Documento);
        Cliente GetCliente(string Documento);
    }
    
        
    }
