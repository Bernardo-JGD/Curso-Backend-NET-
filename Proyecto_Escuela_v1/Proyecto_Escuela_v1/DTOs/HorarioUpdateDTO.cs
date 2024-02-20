namespace Proyecto_Escuela_v1.DTOs
{
    public class HorarioUpdateDTO
    {
        public int Id { get; set; }
        public byte Dia { get; set; }
        public byte HoraInicio { get; set; }
        public byte MinutoInicio { get; set; }
        public byte HoraFin { get; set; }
        public byte MinutoFin { get; set; }
    }
}
