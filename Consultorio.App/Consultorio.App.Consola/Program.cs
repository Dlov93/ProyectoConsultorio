using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Dynamic;
using System;
using Consultorio.App.Dominio;
using Consultorio.App.Persistencia;

namespace Consultorio.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContexto());
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el documento que desea gestionar:");
            string Documento=Console.ReadLine();
           AddCliente();
           //BuscarCliente(Documento);
           //BorrarCliente(Documento);
           //ActualizarCliente(Documento); 
           
        }
        private static void AddCliente(){
            var cliente= new Cliente {
                Documento="1113665480",
                Nombre="Diana",
                Apellido="Ocampo",
                Telefono="3188793266",
                Correo="diana@gmail.com",
                Genero=Genero.Femenino,
                Direccion="Krr45A",
                Ciudad="Palmira",
                FechaNacimiento= new DateTime(1993,12,15)
            };
            _repoCliente.AddCliente(cliente);
        }
        private static void BuscarCliente(string Documento){
        var cliente = _repoCliente.GetCliente(Documento);
        Console.WriteLine(cliente.Nombre);
        Console.WriteLine(cliente.Nombre+" "+ cliente.Apellido+" "+ cliente.Documento);

        } 
        private static void BorrarCliente(string Documento){
            _repoCliente.DeleteCliente(Documento);
        }
        private static void ActualizarCliente(string Documento){
            var clienteEncontrado = _repoCliente.GetCliente(Documento);
            Console.WriteLine(clienteEncontrado.Nombre);
            Console.WriteLine("escriba porfavor el nombre:");
            string nombre=Console.ReadLine();
            Console.WriteLine("escriba porfavor el Apellido:");
            string apellido=Console.ReadLine();
            Console.WriteLine("escriba porfavor el Telefono:");
            string telefono=Console.ReadLine();
            //Console.WriteLine("escriba porfavor el genero:");
            //string Genero=Console.ReadLine();
            Console.WriteLine("escriba porfavor la ciudad:");
            string ciudad=Console.ReadLine();
            Console.WriteLine("escriba porfavor la direccion:");
            string direccion=Console.ReadLine();
            Console.WriteLine("escriba porfavor el correo:");
            string correo=Console.ReadLine();
            Console.WriteLine("escriba porfavor la fecha de Nacimiento:");
            string fechanacimiento=Console.ReadLine();
            var cliente= new Cliente {
                Documento=Documento,
                Nombre=nombre,
                Apellido=apellido,
                Telefono=telefono,
                Correo=correo,
                Genero=Genero.Femenino,
                Direccion=direccion,
                Ciudad=ciudad,
                FechaNacimiento= new DateTime(1993,12,15)
            };
            _repoCliente.UpdateCliente(cliente);


        }
    }
}
