using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Consultorio.App.Dominio{
public class Persona{
    public int ID{get; set;}            //identificador o codigo de cada Persona
    [Required, StringLength(20)]
    public string Documento{get; set;}  //Documento de identidad
    [Required, StringLength(50)]
    public string Nombre{get;set;}
    [Required, StringLength(50)]
    public string Apellido{get; set;}
    [Required, StringLength(20),Phone]
    public string Telefono{get; set;}
    [Required]
    public Genero Genero{get; set;}
    [Required]
    public string UserName {get; set;}
    [Required, StringLength(50), EmailAddress]
    public string Correo{get; set;}
    [Required,DataType(DataType.Password)]
    public string Contraseña{get; set;}
    [NotMapped]
    public string NombreCompleto{ get { return this.Nombre + " " + this.Apellido; } }
    



}
}

