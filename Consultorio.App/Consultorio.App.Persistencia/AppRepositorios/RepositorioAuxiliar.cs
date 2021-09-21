using System;
using System.Collections.Generic;
using System.Linq;
using Consultorio.App.Dominio;

namespace Consultorio.App.Persistencia{
    
    public class RepositorioAuxiliar : IRepositorioAuxiliar{
        private readonly AppContexto _appContext;
        
        public RepositorioAuxiliar(AppContexto appContext){
            _appContext=appContext;
        }
        Auxiliar IRepositorioAuxiliar.AddAuxiliar(Auxiliar auxiliar){
            var auxiliarAdicionado= _appContext.auxiliar.Add(auxiliar);
            _appContext.SaveChanges();
            return auxiliarAdicionado.Entity;
        }
        void IRepositorioAuxiliar.DeleteAuxiliar(string Documento){
            var auxiliarEncontrado= _appContext.auxiliar.FirstOrDefault(a => a.Documento==Documento);
            if(auxiliarEncontrado==null){
            return;
            }
            _appContext.auxiliar.Remove(auxiliarEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Auxiliar> IRepositorioAuxiliar.GetAllAuxiliar(){
            return _appContext.auxiliar;
        }
        Auxiliar IRepositorioAuxiliar.GetAuxiliar(string Documento){
            return _appContext.auxiliar.FirstOrDefault(a => a.Documento==Documento);
        }
        Auxiliar IRepositorioAuxiliar.UpdateAuxiliar(Auxiliar auxiliar){
            var auxiliarEncontrado=_appContext.auxiliar.FirstOrDefault(a => a.Documento==auxiliar.Documento);
            if(auxiliarEncontrado!=null){
                auxiliarEncontrado.Nombre=auxiliar.Nombre;
                auxiliarEncontrado.Apellido=auxiliar.Apellido;
                auxiliarEncontrado.Genero = auxiliar.Genero;
                auxiliarEncontrado.Telefono=auxiliar.Telefono;
                auxiliarEncontrado.CodigoA= auxiliar.CodigoA;
              
                _appContext.SaveChanges();
            }
            return auxiliarEncontrado;

        }

    }
}