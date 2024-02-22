using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Escuela_v1.Models
{
    public class MateriaEstudiante
    {
        public int MateriaID { get; set; }
        public int EstudianteID { get; set; }

        public Materia Materia { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
