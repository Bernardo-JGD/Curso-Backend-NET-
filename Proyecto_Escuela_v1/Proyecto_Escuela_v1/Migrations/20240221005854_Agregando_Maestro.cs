using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Escuela_v1.Migrations
{
    /// <inheritdoc />
    public partial class Agregando_Maestro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maestros",
                columns: table => new
                {
                    MaestroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clave = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Correo = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maestros", x => x.MaestroID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maestros");
        }
    }
}
