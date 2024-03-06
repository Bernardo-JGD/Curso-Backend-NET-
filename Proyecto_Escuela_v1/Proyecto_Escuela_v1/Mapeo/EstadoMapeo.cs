using Proyecto_Escuela_v1.DTOs;
using Proyecto_Escuela_v1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Escuela_v1.Mapeo
{
    public class EstadoMapeo
    {

        public EstadoMapeo()
        {

        }

        public IEnumerable<EstadoDTO> EstadoDTOList(IEnumerable<Estado> listaEstados)
        {
            List<EstadoDTO> listaEstadoDTO = new List<EstadoDTO>();
            foreach (Estado estado in listaEstados)
            {
                listaEstadoDTO.Add(new EstadoDTO
                {
                    Id = estado.EstadoID,
                    Nombre = estado.Nombre,
                    Abreviatura = estado.Abreviatura
                });
            }

            return listaEstadoDTO;
        }

        public EstadoDTO EstadoToEstadoDTO(Estado estado)
        {
            return new EstadoDTO
            {
                Id = estado.EstadoID,
                Nombre = estado.Nombre,
                Abreviatura = estado.Abreviatura
            };
        }

        public Estado EstadoInsertDTOtoEstado(EstadoInsertDTO estadoInsertDTO)
        {
            return new Estado
            {
                Nombre = estadoInsertDTO.Nombre,
                Abreviatura = estadoInsertDTO.Abreviatura
            };
        }

        public void EstadoUpdateDTOtoEstado(Estado estado, EstadoUpdateDTO estadoUpdate)
        {
            estado.Nombre = estadoUpdate.Nombre;
            estado.Abreviatura = estadoUpdate.Abreviatura;
        }
    }
}
