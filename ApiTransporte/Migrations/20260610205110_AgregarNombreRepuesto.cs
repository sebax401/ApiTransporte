using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTransporte.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNombreRepuesto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombreRepuesto",
                table: "Reporte",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreRepuesto",
                table: "Reporte");
        }
    }
}
