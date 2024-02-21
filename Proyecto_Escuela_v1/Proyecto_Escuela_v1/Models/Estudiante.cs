using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Escuela_v1.Models
{
    public class Estudiante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstudianteID { get; set; }

        [Column (TypeName = "VARCHAR(10)")]
        public string Matricula { get; set; }

        [Column (TypeName = "VARCHAR(100)")]
        public string Nombre { get; set; }

        [Column (TypeName = "VARCHAR(40)")]
        public string CURP { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime FechaNacimiento { get; set; }

        //[Column(TypeName = "TINYINT")]
        public int EstadoID { get; set; }

        [ForeignKey("EstadoID")]
        public virtual Estado Estado { get; set; }

    }
}
