namespace Proyecto_Escuela_v1.DTOs
{
    public class EstudianteDTO
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string CURP { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int EstadoID { get; set; }
    }
}
