using Proyecto_Escuela_v1.Context;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Repository
{
    public class UbicacionRepository : IRepository<Ubicacion>
    {
        private EscuelaContext _escuelaContext;

        public UbicacionRepository(EscuelaContext escuelaContext)
        {
            _escuelaContext = escuelaContext;
        }

        public Task<IEnumerable<Ubicacion>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Ubicacion> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Ubicacion entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Ubicacion entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Ubicacion entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ubicacion> Search(Func<Ubicacion, bool> filter)
        {
            throw new NotImplementedException();
        }

    }
}
