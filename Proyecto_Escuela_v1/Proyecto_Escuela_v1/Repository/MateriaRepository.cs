using Proyecto_Escuela_v1.Context;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Repository
{
    public class MateriaRepository : IRepository<Materia>
    {
        private EscuelaContext _escuelaContext;

        public MateriaRepository(EscuelaContext escuelaContext)
        {
            _escuelaContext = escuelaContext;
        }

        public Task<IEnumerable<Materia>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Materia> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Materia entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Materia entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Materia entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Materia> Search(Func<Materia, bool> filter)
        {
            throw new NotImplementedException();
        }

    }
}
