using Microsoft.EntityFrameworkCore;
using Proyecto_Escuela_v1.Context;
using Proyecto_Escuela_v1.Models;

namespace Proyecto_Escuela_v1.Repository
{
    public class EstadoRepository : IRepository<Estado>
    {
        private EscuelaContext _escuelaContext;

        public EstadoRepository(EscuelaContext escuelaContext)
        {
            _escuelaContext = escuelaContext;
        }

        public async Task<IEnumerable<Estado>> Get()
            => await _escuelaContext.Estados.ToListAsync();


        public async Task<Estado> GetById(int id)
            => await _escuelaContext.Estados.FindAsync(id);

        public async Task Add(Estado estado)
            => await _escuelaContext.Estados.AddAsync(estado);

        public void Update(Estado estado)
        {
            _escuelaContext.Estados.Attach(estado);
            _escuelaContext.Estados.Entry(estado).State = EntityState.Modified;
        }

        public void Delete(Estado estado)
            => _escuelaContext.Remove(estado);

        public async Task Save()
            => await _escuelaContext.SaveChangesAsync();

        public IEnumerable<Estado> Search(Func<Estado, bool> filter)
            => _escuelaContext.Estados.Where(filter).ToList();

    }
}
