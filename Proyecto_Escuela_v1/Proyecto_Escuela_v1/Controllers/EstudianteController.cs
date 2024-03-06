using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Escuela_v1.DTOs;
using Proyecto_Escuela_v1.Services;

namespace Proyecto_Escuela_v1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private ICommonService<EstudianteDTO, EstudianteInsertDTO, EstudianteUpdateDTO> _estudianteService;

        public EstudianteController(
                ICommonService<EstudianteDTO, EstudianteInsertDTO, EstudianteUpdateDTO> estudianteService
            )
        {
            _estudianteService = estudianteService;
        }

        [HttpGet]
        public async Task<IEnumerable<EstudianteDTO>> Get()
            => await _estudianteService.Get();

        [HttpGet("{id}")]
        public async Task<ActionResult<EstudianteDTO>> GetById(int id)
        {
            var estudianteDto = await _estudianteService.GetById(id);

            return estudianteDto == null ? NotFound() : Ok(estudianteDto);
        }
             

        [HttpPost]
        public async Task<ActionResult<EstudianteDTO>> Add(EstudianteInsertDTO estudianteInsertDto)
        {
            /*
             Validar
             */

            var estudiante = await _estudianteService.Add(estudianteInsertDto);

            return CreatedAtAction(nameof(GetById), new {id = estudiante.Id}, estudiante);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EstudianteDTO>> Update(int id, EstudianteUpdateDTO estudianteUpdateDto)
        {
            /*
             Validar
             */

            var estudiante = await _estudianteService.Update(id, estudianteUpdateDto);

            return estudiante == null ? NotFound() : Ok(estudiante);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EstudianteDTO>> Delete(int id)
        {
            var estudianteDto = await _estudianteService.Delete(id);

            return estudianteDto == null ? NotFound() : Ok(estudianteDto);
        }
    }
}
