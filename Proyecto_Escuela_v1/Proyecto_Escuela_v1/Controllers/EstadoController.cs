using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Escuela_v1.DTOs;
using Proyecto_Escuela_v1.Services;

namespace Proyecto_Escuela_v1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private ICommonService<EstadoDTO, EstadoInsertDTO, EstadoUpdateDTO> _estadoService;

        public EstadoController
            (
                ICommonService<EstadoDTO, EstadoInsertDTO, EstadoUpdateDTO> estadoService
            )
        {
            _estadoService = estadoService;
        }

        [HttpGet]
        public async Task<IEnumerable<EstadoDTO>> Get()
            => await _estadoService.Get();

        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoDTO>> GetById(int id)
        {
            var estadoDto = await _estadoService.GetById(id);

            return estadoDto == null ? NotFound() : Ok(estadoDto);
        }

        [HttpPost]
        public async Task<ActionResult<EstadoDTO>> Add(EstadoInsertDTO estadoInsertDto)
        {
            /*
              validar
            */

            var estadoDto = await _estadoService.Add(estadoInsertDto);

            return CreatedAtAction(nameof(GetById), new { id = estadoDto.Id }, estadoDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EstadoDTO>> Update(int id, EstadoUpdateDTO estadoUpdateDto)
        {
            /*
             Validar
             */

            var estadoDto = await _estadoService.Update(id, estadoUpdateDto);

            return estadoDto == null ? NotFound() : Ok(estadoDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EstadoDTO>> Delete(int id)
        {
            var estadoDto = await _estadoService.Delete(id);

            return estadoDto == null ? NotFound() : Ok(estadoDto);
        }

    }
}
