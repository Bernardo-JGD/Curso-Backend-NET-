namespace Proyecto_Escuela_v1.DTOs
{
    public class MateriaUpdateDTO
    {
        public int Id { get; set; }
        public string ClaveMateria { get; set; }
        public string Nombre { get; set; }
        public byte CreditosRequeridos { get; set; }
        public byte CreditosOtorgados { get; set; }
        public byte Semestre { get; set; }
        public byte Cupo { get; set; }
        public DateTime FechaInicioSemestre { get; set; }
        public DateTime FechaFinSesmestre { get; set; }

    }
}
