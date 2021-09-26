using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioCliente : IRepositorioCliente{
        private readonly AppContexto _appContexto;
        
        public RepositorioCliente(AppContexto appContexto){
            _appContexto=appContexto;
        }
        Cliente IRepositorioCliente.AddCliente(Cliente cliente){
            var clienteAdicionado= _appContexto.cliente.Add(cliente);
            _appContexto.SaveChanges();
            return clienteAdicionado.Entity;
        }
        void IRepositorioCliente.DeleteCliente(string Documento){
            var clienteEncontrado= _appContexto.cliente.FirstOrDefault(c => c.Documento==Documento);
            if(clienteEncontrado==null){
            return;
            }
            _appContexto.cliente.Remove(clienteEncontrado);
            _appContexto.SaveChanges();
        }
        IEnumerable<Cliente> IRepositorioCliente.GetAllCliente(){
            return _appContexto.cliente;
        }
        Cliente IRepositorioCliente.GetCliente(string Documento){
            return _appContexto.cliente.FirstOrDefault(c => c.Documento==Documento);
        }
        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente){
            var clienteEncontrado=_appContexto.cliente.FirstOrDefault(c => c.Documento==cliente.Documento);
            if(clienteEncontrado!=null){
                clienteEncontrado.Nombre=cliente.Nombre;
                clienteEncontrado.Apellido=cliente.Apellido;
                clienteEncontrado.Genero = cliente.Genero;
                clienteEncontrado.Telefono=cliente.Telefono;
                clienteEncontrado.Ciudad= cliente.Ciudad;
                clienteEncontrado.Direccion= cliente.Direccion;
                clienteEncontrado.Correo= cliente.Correo;
                clienteEncontrado.FechaNacimiento= cliente.FechaNacimiento;
                _appContexto.SaveChanges();
            }
            return clienteEncontrado;

        }

    }
}