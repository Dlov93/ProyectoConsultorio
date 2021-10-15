using System.Collections.Immutable;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Consultorio.App.Dominio;

namespace Consultorio.App.Persistencia {
    public class AppContexto : DbContext{
        public DbSet<Persona> persona {get; set;}
        public DbSet<Cliente> cliente {get; set;}
        public DbSet<Medico> medico {get; set;}
        public DbSet<Auxiliar> auxiliar {get; set;}
        public DbSet<Cita> cita {get; set;}
        public DbSet<Horario> horarios {get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder option){
            if(!option.IsConfigured){
                option.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB; initial Catalog=Consultorio1.0");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Persona>()
            .HasIndex(p => p.Documento)
            .IsUnique();
            
        }
    }


}