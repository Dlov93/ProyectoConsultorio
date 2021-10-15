using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.App.Persistencia.Migrations
{
    public partial class jl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RegistroRethus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "cita",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteID = table.Column<int>(type: "int", nullable: true),
                    medicoID = table.Column<int>(type: "int", nullable: true),
                    auxiliarID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cita", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cita_persona_auxiliarID",
                        column: x => x.auxiliarID,
                        principalTable: "persona",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cita_persona_clienteID",
                        column: x => x.clienteID,
                        principalTable: "persona",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cita_persona_medicoID",
                        column: x => x.medicoID,
                        principalTable: "persona",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    Hora_Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora_Final = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_horarios_persona_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "persona",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cita_auxiliarID",
                table: "cita",
                column: "auxiliarID");

            migrationBuilder.CreateIndex(
                name: "IX_cita_clienteID",
                table: "cita",
                column: "clienteID");

            migrationBuilder.CreateIndex(
                name: "IX_cita_medicoID",
                table: "cita",
                column: "medicoID");

            migrationBuilder.CreateIndex(
                name: "IX_horarios_MedicoID",
                table: "horarios",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_persona_Documento",
                table: "persona",
                column: "Documento",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cita");

            migrationBuilder.DropTable(
                name: "horarios");

            migrationBuilder.DropTable(
                name: "persona");
        }
    }
}
