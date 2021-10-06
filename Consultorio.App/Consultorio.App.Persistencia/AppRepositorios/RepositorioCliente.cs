using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioCliente : IRepositorioCliente{
        private readonly AppContexto _appContexto;
        private readonly Security security;

        
        public RepositorioCliente(AppContexto appContexto){
            _appContexto=appContexto;
            security =new Security();
        }
        public Cliente AddCliente(Cliente cliente){
            cliente.Contraseña = security.GetMD5Hash(cliente.Contraseña);
            Cliente clienteAdicionado= _appContexto.Add(cliente).Entity;
            _appContexto.SaveChanges();
            return clienteAdicionado;
        }
        public void DeleteCliente(string Documento){
            var clienteEncontrado= _appContexto.cliente.FirstOrDefault(c => c.Documento==Documento);
            if(clienteEncontrado==null){
            return;
            }
            _appContexto.cliente.Remove(clienteEncontrado);
            _appContexto.SaveChanges();
        }
        public IEnumerable<Cliente> GetAllCliente(){
            return _appContexto.cliente;
        }
        public Cliente GetCliente(string Documento){
            return _appContexto.cliente.FirstOrDefault(c => c.Documento==Documento);
        }
        public Cliente UpdateCliente(Cliente cliente){
            cliente.Contraseña = security.GetMD5Hash(cliente.Contraseña);
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
                clienteEncontrado.UserName= cliente.UserName;
                clienteEncontrado.Contraseña=cliente.Contraseña;
                _appContexto.SaveChanges();
            }
            return clienteEncontrado;

        }

    }
}