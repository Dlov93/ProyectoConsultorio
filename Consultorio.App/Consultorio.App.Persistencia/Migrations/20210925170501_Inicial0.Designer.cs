﻿// <auto-generated />
using System;
using Consultorio.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Consultorio.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContexto))]
    [Migration("20210925170501_Inicial0")]
    partial class Inicial0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Consultorio.App.Dominio.Cita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("auxiliarID")
                        .HasColumnType("int");

                    b.Property<int?>("clienteID")
                        .HasColumnType("int");

                    b.Property<int?>("medicoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("auxiliarID");

                    b.HasIndex("clienteID");

                    b.HasIndex("medicoID");

                    b.ToTable("cita");
                });

            modelBuilder.Entity("Consultorio.App.Dominio.Horario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaDisponible")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("horario");
                });

            modelBuilder.Entity("Consultorio.App.Dominio.Persona", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Documento")
                        .IsUnique()
                        .HasFilter("[Documento] IS NOT NULL");

                    b.ToTable("persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Consultorio.App.Dominio.Auxiliar", b =>
                {
                    b.HasBaseType("Consultorio.App.Dominio.Persona");

                    b.Property<string>("CodigoA")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Auxiliar");
                });

            modelBuilder.Entity("Consultorio.App.Dominio.Cliente", b =>
                {
                    b.HasBaseType("Consultorio.App.Dominio.Persona");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Consultorio.App.Dominio.Medico", b =>
                {
                    b.HasBaseType("Consultorio.App.Dominio.Persona");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HorarioID")
                        .HasColumnType("int");

                    b.Property<string>("RegistroRethus")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("HorarioID");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("Consultorio.App.Dominio.Cita", b =>
                {
                    b.HasOne("Consultorio.App.Dominio.Auxiliar", "auxiliar")
                        .WithMany()
                        .HasForeignKey("auxiliarID");

                    b.HasOne("Consultorio.App.Dominio.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteID");

                    b.HasOne("Consultorio.App.Dominio.Medico", "medico")
                        .WithMany()
                        .HasForeignKey("medicoID");

                    b.Navigation("auxiliar");

                    b.Navigation("cliente");

                    b.Navigation("medico");
                });

            modelBuilder.Entity("Consultorio.App.Dominio.Medico", b =>
                {
                    b.HasOne("Consultorio.App.Dominio.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("HorarioID");

                    b.Navigation("Horario");
                });
#pragma warning restore 612, 618
        }
    }
}
