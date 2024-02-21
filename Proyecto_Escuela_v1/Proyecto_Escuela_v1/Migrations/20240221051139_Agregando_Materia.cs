using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Escuela_v1.Migrations
{
    /// <inheritdoc />
    public partial class Agregando_Materia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    MateriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaveMateria = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CreditosRequeridos = table.Column<byte>(type: "TINYINT", nullable: false),
                    CreditosOtorgados = table.Column<byte>(type: "TINYINT", nullable: false),
                    Semestre = table.Column<byte>(type: "TINYINT", nullable: false),
                    Cupo = table.Column<byte>(type: "TINYINT", nullable: false),
                    FechaInicioSemestre = table.Column<DateTime>(type: "DATE", nullable: false),
                    FechaFinSemestre = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.MateriaID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materias");
        }
    }
}
