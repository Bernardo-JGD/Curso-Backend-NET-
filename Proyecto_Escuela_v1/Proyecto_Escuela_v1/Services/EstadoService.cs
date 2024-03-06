using Proyecto_Escuela_v1.DTOs;
using Proyecto_Escuela_v1.Mapeo;
using Proyecto_Escuela_v1.Models;
using Proyecto_Escuela_v1.Repository;

namespace Proyecto_Escuela_v1.Services
{
    public class EstadoService : ICommonService<EstadoDTO, EstadoInsertDTO, EstadoUpdateDTO>
    {
        private IRepository<Estado> _estadoRepository;
        private EstadoMapeo _estadoMapeo;

        public EstadoService(IRepository<Estado> estadoRepository)
        {
            _estadoRepository = estadoRepository;
            _estadoMapeo = new EstadoMapeo();
        }

        public async Task<IEnumerable<EstadoDTO>> Get()
        {
            var estados = await _estadoRepository.Get();
            var estadosDto = _estadoMapeo.EstadoDTOList(estados);

            return estadosDto;
        }

        public async Task<EstadoDTO> GetById(int id)
        {
            var estado = await _estadoRepository.GetById(id);
            var estadoDto = _estadoMapeo.EstadoToEstadoDTO(estado);

            return estadoDto;
        }
        public async Task<EstadoDTO> Add(EstadoInsertDTO estadoInsertDto)
        {
            var estado = _estadoMapeo.EstadoInsertDTOtoEstado(estadoInsertDto);

            await _estadoRepository.Add(estado);
            await _estadoRepository.Save();

            var estadoDto = _estadoMapeo.EstadoToEstadoDTO(estado);

            return estadoDto;
        }

        public async Task<EstadoDTO> Update(int id, EstadoUpdateDTO estadoUpdateDto)
        {
            var estado = await _estadoRepository.GetById(id);

            if (estado != null)
            {
                _estadoMapeo.EstadoUpdateDTOtoEstado(estado, estadoUpdateDto);

                _estadoRepository.Update(estado);
                await _estadoRepository.Save();

                var estadoDto = _estadoMapeo.EstadoToEstadoDTO(estado);

                return estadoDto;
            }

            return null;
        }

        public async Task<EstadoDTO> Delete(int id)
        {
            var estado = await _estadoRepository.GetById(id);

            if (estado != null)
            {
                var estadoDto = _estadoMapeo.EstadoToEstadoDTO(estado);

                _estadoRepository.Delete(estado);
                await _estadoRepository.Save();

                return estadoDto;
            }

            return null;
        }

        
    }
}
