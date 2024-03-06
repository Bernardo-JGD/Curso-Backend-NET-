using Microsoft.EntityFrameworkCore;
using Proyecto_Escuela_v1.Context;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Repository
{
    public class EstudianteRepository : IRepository<Estudiante>
    {
        private EscuelaContext _escuelaContext;

        public EstudianteRepository(EscuelaContext escuelaContext)
        {
            _escuelaContext = escuelaContext;
        }

        public async Task<IEnumerable<Estudiante>> Get()
            => await _escuelaContext.Estudiantes.ToListAsync();

        public async Task<Estudiante> GetById(int id)
            => await _escuelaContext.Estudiantes.FindAsync(id);

        public async Task Add(Estudiante estudiante)
            => await _escuelaContext.Estudiantes.AddAsync(estudiante);

        public void Update(Estudiante estudiante)
        {
            _escuelaContext.Attach(estudiante);
            _escuelaContext.Estudiantes.Entry(estudiante).State = EntityState.Modified;
        }

        public void Delete(Estudiante estudiante)
            => _escuelaContext.Estudiantes.Remove(estudiante);

        public async Task Save()
            => await _escuelaContext.SaveChangesAsync();

        public IEnumerable<Estudiante> Search(Func<Estudiante, bool> filter)
            => _escuelaContext.Estudiantes.Where(filter).ToList();

        
    }
}
