using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTransporte.Migrations
{
    /// <inheritdoc />
    public partial class SQLiteMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Patente = table.Column<string>(type: "TEXT", nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: true),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    Anio = table.Column<int>(type: "INTEGER", nullable: false),
                    ProximoKilometraje = table.Column<int>(type: "INTEGER", nullable: true),
                    FechaRevisionTecnica = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FechaUltimaMantencion = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FechaProximaMantencion = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EstadoDpf = table.Column<string>(type: "TEXT", nullable: true),
                    EstadoRevision = table.Column<string>(type: "TEXT", nullable: true),
                    EstadoExtintor = table.Column<string>(type: "TEXT", nullable: true),
                    Observacion = table.Column<string>(type: "TEXT", nullable: true),
                    IdConductor = table.Column<int>(type: "INTEGER", nullable: true),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.IdVehiculo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehiculo");
        }
    }
}
