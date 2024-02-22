namespace Proyecto_Escuela_v1.Models
{
    public class Imparte
    {
        public int MaestroID { get; set; }
        public int MateriaID { get; set; }
        public int HorarioID { get; set; }
        public byte UbicacionID { get; set; }

        public Maestro Maestro { get; set; }
        public Materia Materia { get; set; }
        public Horario Horario { get; set; }
        public Ubicacion Ubicacion { get; set; }

    }
}
