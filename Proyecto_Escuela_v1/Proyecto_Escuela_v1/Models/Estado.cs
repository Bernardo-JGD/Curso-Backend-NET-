using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Escuela_v1.Models
{
    public class Estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column(TypeName = "TINYINT")]
        public int EstadoID { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string Nombre { get; set; }
        [Column(TypeName = "VARCHAR(3)")]
        public string Abreviatura { get; set; }
    }
}
