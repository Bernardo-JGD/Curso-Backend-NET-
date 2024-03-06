using Proyecto_Escuela_v1.Context;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Repository
{
    public class HorarioRepository : IRepository<Horario>
    {
        private EscuelaContext _escuelaContext;

        public HorarioRepository(EscuelaContext escuelaContext)
        {
            _escuelaContext = escuelaContext;
        }

        public Task<IEnumerable<Horario>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Horario> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Horario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Horario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Horario entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Horario> Search(Func<Horario, bool> filter)
        {
            throw new NotImplementedException();
        }

    }
}
