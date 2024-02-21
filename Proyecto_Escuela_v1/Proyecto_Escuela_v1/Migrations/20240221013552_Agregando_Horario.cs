using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Escuela_v1.Migrations
{
    /// <inheritdoc />
    public partial class Agregando_Horario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    HorarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<byte>(type: "TINYINT", nullable: false),
                    HoraInicio = table.Column<byte>(type: "TINYINT", nullable: false),
                    MinutoInicio = table.Column<byte>(type: "TINYINT", nullable: false),
                    HoraFin = table.Column<byte>(type: "TINYINT", nullable: false),
                    MinutoFin = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.HorarioID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horarios");
        }
    }
}
