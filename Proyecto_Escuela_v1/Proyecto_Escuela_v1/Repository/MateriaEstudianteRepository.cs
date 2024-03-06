using Proyecto_Escuela_v1.Context;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Repository
{
    public class MateriaEstudianteRepository : IRepository<MateriaEstudiante>
    {
        private EscuelaContext _escuelaContext;

        public MateriaEstudianteRepository(EscuelaContext escuelaContext)
        {
            _escuelaContext = escuelaContext;
        }

        public Task<IEnumerable<MateriaEstudiante>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<MateriaEstudiante> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(MateriaEstudiante entity)
        {
            throw new NotImplementedException();
        }

        public void Update(MateriaEstudiante entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MateriaEstudiante entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MateriaEstudiante> Search(Func<MateriaEstudiante, bool> filter)
        {
            throw new NotImplementedException();
        }

    }
}
