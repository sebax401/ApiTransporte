using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTransporte.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarModeloReportes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LugarCompra",
                table: "Reporte",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorRepuesto",
                table: "Reporte",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LugarCompra",
                table: "Reporte");

            migrationBuilder.DropColumn(
                name: "ValorRepuesto",
                table: "Reporte");
        }
    }
}
