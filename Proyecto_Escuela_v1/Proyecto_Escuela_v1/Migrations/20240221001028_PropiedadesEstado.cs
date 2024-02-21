using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Escuela_v1.Migrations
{
    /// <inheritdoc />
    public partial class PropiedadesEstado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Estados",
                type: "VARCHAR(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Abreviatura",
                table: "Estados",
                type: "VARCHAR(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Estados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(25)");

            migrationBuilder.AlterColumn<string>(
                name: "Abreviatura",
                table: "Estados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)");
        }
    }
}
