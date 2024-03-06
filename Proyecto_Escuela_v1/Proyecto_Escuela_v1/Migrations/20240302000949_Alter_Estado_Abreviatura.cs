using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Escuela_v1.Migrations
{
    /// <inheritdoc />
    public partial class Alter_Estado_Abreviatura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Abreviatura",
                table: "Estados",
                type: "VARCHAR(5)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Abreviatura",
                table: "Estados",
                type: "VARCHAR(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(5)");
        }
    }
}
