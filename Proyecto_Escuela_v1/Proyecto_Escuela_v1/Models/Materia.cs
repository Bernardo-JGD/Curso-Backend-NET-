using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Escuela_v1.Models
{
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MateriaID { get; set; }

        [Column(TypeName = "VARCHAR(10)")]
        public string ClaveMateria { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Nombre { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte CreditosRequeridos { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte CreditosOtorgados { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte Semestre { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte Cupo { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime FechaInicioSemestre { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime FechaFinSemestre { get; set; }
    }
}
