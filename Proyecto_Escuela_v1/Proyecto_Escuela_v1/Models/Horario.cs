using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Escuela_v1.Models
{
    public class Horario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HorarioID { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte Dia { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte HoraInicio { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte MinutoInicio { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte HoraFin { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte MinutoFin { get; set; }
    }
}
