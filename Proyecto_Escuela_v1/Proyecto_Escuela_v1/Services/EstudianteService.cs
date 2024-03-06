using Proyecto_Escuela_v1.DTOs;
using Proyecto_Escuela_v1.Mapeo;
using Proyecto_Escuela_v1.Models;
using Proyecto_Escuela_v1.Repository;

namespace Proyecto_Escuela_v1.Services
{
    public class EstudianteService : ICommonService<EstudianteDTO, EstudianteInsertDTO, EstudianteUpdateDTO>
    {
        private IRepository<Estudiante> _estudianteRepository;
        private EstudianteMapeo _estudianteMapeo;

        public EstudianteService(IRepository<Estudiante> estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
            _estudianteMapeo = new EstudianteMapeo();
        }

        public async Task<IEnumerable<EstudianteDTO>> Get()
        {
            var estudiantes = await _estudianteRepository.Get();
            var estudiantesDTO = _estudianteMapeo.EstudianteDTOList(estudiantes);

            return estudiantesDTO;
        }

        public async Task<EstudianteDTO> GetById(int id)
        {
            var estudiante = await _estudianteRepository.GetById(id);

            if (estudiante != null)
            {
                var estudianteDto = _estudianteMapeo.EstudianteToEstudianteDTO(estudiante);

                return estudianteDto;
            }

            return null;
        }

        public async Task<EstudianteDTO> Add(EstudianteInsertDTO estudianteInsertDto)
        {
            var estudiante = _estudianteMapeo.EstudianteInsertDTOtoEstudiante(estudianteInsertDto);

            await _estudianteRepository.Add(estudiante);
            await _estudianteRepository.Save();

            var estudianteDto = _estudianteMapeo.EstudianteToEstudianteDTO(estudiante);

            return estudianteDto;
        }

        public async Task<EstudianteDTO> Update(int id, EstudianteUpdateDTO estudianteUpdateDto)
        {
            var estudiante = await _estudianteRepository.GetById(id);

            if (estudiante != null)
            {
                _estudianteMapeo.EstudianteUpdateDTOtoEstudiante(estudiante, estudianteUpdateDto);

                _estudianteRepository.Update(estudiante);
                await _estudianteRepository.Save();

                var estudianteDto = _estudianteMapeo.EstudianteToEstudianteDTO(estudiante);

                return estudianteDto;
            }

            return null;

        }

        public async Task<EstudianteDTO> Delete(int id)
        {
            var estudiante = await _estudianteRepository.GetById(id);

            if (estudiante != null)
            {
                var estudianteDto = _estudianteMapeo.EstudianteToEstudianteDTO(estudiante);

                _estudianteRepository.Delete(estudiante);
                await _estudianteRepository.Save();

                return estudianteDto;
            }

            return null;
        }
    }
}
