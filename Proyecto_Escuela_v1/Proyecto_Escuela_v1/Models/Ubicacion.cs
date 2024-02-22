using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Escuela_v1.Models
{
    public class Ubicacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "TINYINT")]
        public byte UbicacionID { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte Edificio { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte Planta { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte Salon { get; set; }

        public List<Imparte> Impartes { get; set; }
    }
}
