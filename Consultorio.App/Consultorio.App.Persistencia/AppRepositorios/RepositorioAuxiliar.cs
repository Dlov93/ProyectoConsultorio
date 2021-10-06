using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioAuxiliar : IRepositorioAuxiliar{
        private readonly AppContexto _appContext;
        private readonly Security security;

        
        public RepositorioAuxiliar(AppContexto appContext){
            _appContext=appContext;
            security = new Security();
        }
        public Auxiliar AddAuxiliar(Auxiliar auxiliar){
            auxiliar.Contraseña = security.GetMD5Hash(auxiliar.Contraseña);
            Auxiliar auxiliarAdicionado= _appContext.Add(auxiliar).Entity;
            _appContext.SaveChanges();
            return auxiliarAdicionado;
        }
        public void DeleteAuxiliar(string Documento){
            var auxiliarEncontrado= _appContext.auxiliar.FirstOrDefault(a => a.Documento==Documento);
            if(auxiliarEncontrado==null){
            return;
            }
            _appContext.auxiliar.Remove(auxiliarEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Auxiliar> GetAllAuxiliar(){
            return _appContext.auxiliar;
        }
        public Auxiliar GetAuxiliar(string Documento){
            return _appContext.auxiliar.FirstOrDefault(a => a.Documento==Documento);
        }
        public Auxiliar UpdateAuxiliar(Auxiliar auxiliar){
            
            auxiliar.Contraseña = security.GetMD5Hash(auxiliar.Contraseña);
            var auxiliarEncontrado=_appContext.auxiliar.FirstOrDefault(a => a.Documento==auxiliar.Documento);
            if(auxiliarEncontrado!=null){
                auxiliarEncontrado.Nombre=auxiliar.Nombre;
                auxiliarEncontrado.Apellido=auxiliar.Apellido;
                auxiliarEncontrado.Genero = auxiliar.Genero;
                auxiliarEncontrado.Telefono=auxiliar.Telefono;
                auxiliarEncontrado.CodigoA= auxiliar.CodigoA;
                auxiliarEncontrado.UserName= auxiliar.UserName;
                auxiliarEncontrado.Correo= auxiliar.Correo;
                auxiliarEncontrado.Contraseña=auxiliar.Contraseña;

                
              
                _appContext.SaveChanges();
            }
            return auxiliarEncontrado;

        }

    }
}