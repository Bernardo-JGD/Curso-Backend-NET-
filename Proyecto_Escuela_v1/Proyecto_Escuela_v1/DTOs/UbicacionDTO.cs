namespace Proyecto_Escuela_v1.DTOs
{

    //https://stackoverflow.com/questions/425389/c-sharp-equivalent-of-sql-server-datatypes
    public class UbicacionDTO
    {
        public byte Id { get; set; }
        public byte Edificio { get; set; }
        public byte Planta { get; set; }
        public byte Salon { get; set; }
    }
}
