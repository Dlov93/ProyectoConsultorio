using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioCliente : IRepositorioCliente{
        private readonly AppContext _appContext;
        
        public RepositorioCliente(AppContext appContext){
            _appContext=appContext;
        }
        Cliente IRepositorioCliente.AddCliente(Cliente cliente){
            var clienteAdicionado= _appContext.cliente.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }
        void IRepositorioCliente.DeleteCliente(string Documento){
            var clienteEncontrado= _appContext.cliente.FirstOrDefault(c => c.Documento==Documento);
            if(clienteEncontrado==null){
            return;
            }
            _appContext.cliente.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Cliente> IRepositorioCliente.GetAllCliente(){
            return _appContext.cliente;
        }
        Cliente IRepositorioCliente.GetCliente(string Documento){
            return _appContext.cliente.FirstOrDefault(c => c.Documento==Documento);
        }
        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente){
            var clienteEncontrado=_appContext.cliente.FirstOrDefault(c => c.Documento==cliente.Documento);
            if(clienteEncontrado!=null){
                clienteEncontrado.Nombre=cliente.Nombre;
                clienteEncontrado.Apellido=cliente.Apellido;
                clienteEncontrado.Genero = cliente.Genero;
                clienteEncontrado.Telefono=cliente.Telefono;
                clienteEncontrado.Ciudad= cliente.Ciudad;
                clienteEncontrado.Direccion= cliente.Direccion;
                clienteEncontrado.Correo= cliente.Correo;
                clienteEncontrado.FechaNacimiento= cliente.FechaNacimiento;
                _appContext.SaveChanges();
            }
            return clienteEncontrado;

        }

    }
}