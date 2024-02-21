using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Escuela_v1.Models
{
    public class Maestro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaestroID { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string Clave { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Nombre { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Correo { get; set; }
    }
}
