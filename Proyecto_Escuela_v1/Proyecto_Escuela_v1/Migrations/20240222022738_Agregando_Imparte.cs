using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Escuela_v1.Migrations
{
    /// <inheritdoc />
    public partial class Agregando_Imparte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Impartes",
                columns: table => new
                {
                    MaestroID = table.Column<int>(type: "int", nullable: false),
                    MateriaID = table.Column<int>(type: "int", nullable: false),
                    HorarioID = table.Column<int>(type: "int", nullable: false),
                    UbicacionID = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impartes", x => new { x.MaestroID, x.MateriaID, x.HorarioID, x.UbicacionID });
                    table.ForeignKey(
                        name: "FK_Impartes_Horarios_HorarioID",
                        column: x => x.HorarioID,
                        principalTable: "Horarios",
                        principalColumn: "HorarioID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Impartes_Maestros_MaestroID",
                        column: x => x.MaestroID,
                        principalTable: "Maestros",
                        principalColumn: "MaestroID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Impartes_Materias_MateriaID",
                        column: x => x.MateriaID,
                        principalTable: "Materias",
                        principalColumn: "MateriaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Impartes_Ubicaciones_UbicacionID",
                        column: x => x.UbicacionID,
                        principalTable: "Ubicaciones",
                        principalColumn: "UbicacionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Impartes_HorarioID",
                table: "Impartes",
                column: "HorarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Impartes_MateriaID",
                table: "Impartes",
                column: "MateriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Impartes_UbicacionID",
                table: "Impartes",
                column: "UbicacionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Impartes");
        }
    }
}
