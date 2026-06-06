using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTransporte.Migrations
{
    /// <inheritdoc />
    public partial class AgregarRelacionReporteVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reporte",
                columns: table => new
                {
                    IdReporte = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoReporte = table.Column<string>(type: "TEXT", nullable: false),
                    FechaGeneracion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    IdVehiculo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporte", x => x.IdReporte);
                    table.ForeignKey(
                        name: "FK_Reporte_Vehiculo_IdVehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculo",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reporte_IdVehiculo",
                table: "Reporte",
                column: "IdVehiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reporte");
        }
    }
}
