using Proyecto_Escuela_v1.Context;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Repository
{
    public class MaestroRepository : IRepository<Maestro>
    {
        private EscuelaContext _escuelaContext;

        public MaestroRepository(EscuelaContext escuelaContext)
        {
            _escuelaContext = escuelaContext;
        }

        public Task<IEnumerable<Maestro>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Maestro> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Maestro entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Maestro entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Maestro entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Maestro> Search(Func<Maestro, bool> filter)
        {
            throw new NotImplementedException();
        }

    }
}
