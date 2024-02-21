using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Escuela_v1.Migrations
{
    /// <inheritdoc />
    public partial class Agregando_DbSet_Ubicacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    UbicacionID = table.Column<byte>(type: "TINYINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edificio = table.Column<byte>(type: "TINYINT", nullable: false),
                    Planta = table.Column<byte>(type: "TINYINT", nullable: false),
                    Salon = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.UbicacionID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ubicaciones");
        }
    }
}
