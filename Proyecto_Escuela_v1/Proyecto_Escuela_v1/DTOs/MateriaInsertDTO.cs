namespace Proyecto_Escuela_v1.DTOs
{
    public class MateriaInsertDTO
    {
        public string ClaveMateria { get; set; }
        public string Nombre { get; set; }
        public byte CreditosRequereidos { get; set; }
        public byte CreditosOtorgados { get; set; }
        public byte Semestre { get; set; }
        public DateTime FechaInicioSemestre { get; set; }
        public DateTime FechaFinSemestre { get; set; }

    }
}
