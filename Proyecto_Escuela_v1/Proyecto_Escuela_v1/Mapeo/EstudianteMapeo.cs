using Proyecto_Escuela_v1.DTOs;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Mapeo
{
    public class EstudianteMapeo
    {
        public EstudianteMapeo()
        {

        }

        public IEnumerable<EstudianteDTO> EstudianteDTOList(IEnumerable<Estudiante> listaEstudiantes)
        {
            List<EstudianteDTO> listaEstudiantesDTO = new List<EstudianteDTO>();
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                listaEstudiantesDTO.Add(new EstudianteDTO
                {
                    Id = estudiante.EstudianteID,
                    Matricula = estudiante.Matricula,
                    Nombre = estudiante.Nombre,
                    CURP = estudiante.CURP,
                    FechaNacimiento = estudiante.FechaNacimiento,
                    EstadoID = estudiante.EstadoID
                });
            }
            return listaEstudiantesDTO;
        }

        public EstudianteDTO EstudianteToEstudianteDTO(Estudiante estudiante)
        {
            return new EstudianteDTO
            {
                Id = estudiante.EstudianteID,
                Matricula = estudiante.Matricula,
                Nombre = estudiante.Nombre,
                CURP = estudiante.CURP,
                FechaNacimiento = estudiante.FechaNacimiento,
                EstadoID = estudiante.EstadoID
            };
        }

        public Estudiante EstudianteInsertDTOtoEstudiante(EstudianteInsertDTO estudiante)
        {
            return new Estudiante
            {
                Matricula = estudiante.Matricula,
                Nombre = estudiante.Nombre,
                CURP = estudiante.CURP,
                FechaNacimiento = estudiante.FechaNacimiento,
                EstadoID = estudiante.EstadoID
            };
        }

        public void EstudianteUpdateDTOtoEstudiante(Estudiante estudiante, EstudianteUpdateDTO estudianteUpdateDto)
        {
            // Actualiza las propiedades del estudiante existente con los valores del DTO
            estudiante.Matricula = estudianteUpdateDto.Matricula;
            estudiante.Nombre = estudianteUpdateDto.Nombre;
            estudiante.CURP = estudianteUpdateDto.CURP;
            estudiante.FechaNacimiento = estudianteUpdateDto.FechaNacimiento;
            estudiante.EstadoID = estudianteUpdateDto.EstadoID;
        }


    }
}
