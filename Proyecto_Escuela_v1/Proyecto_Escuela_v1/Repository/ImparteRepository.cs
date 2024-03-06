using Proyecto_Escuela_v1.Context;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Repository
{
    public class ImparteRepository : IRepository<Imparte>
    {
        private EscuelaContext _escuelaContext;

        public ImparteRepository(EscuelaContext escuelaContext)
        {
            _escuelaContext = escuelaContext;
        }

        public Task<IEnumerable<Imparte>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Imparte> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Imparte entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Imparte entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Imparte entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Imparte> Search(Func<Imparte, bool> filter)
        {
            throw new NotImplementedException();
        }

    }
}
