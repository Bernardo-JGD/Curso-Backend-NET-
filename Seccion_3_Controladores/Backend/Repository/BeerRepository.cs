using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class BeerRepository : IRepository<Beer>
    {
        private StoreContext _storeContext;

        public BeerRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<IEnumerable<Beer>> Get()
            => await _storeContext.Beers.ToListAsync();

        public async Task<Beer> GetById(int id)
            => await _storeContext.Beers.FindAsync(id);

        public async Task Add(Beer beer)
            => await _storeContext.Beers.AddAsync(beer);

        public void Update(Beer beer)
        {
            //con "Attach" agregamos la entidad (beer) al contexto
            _storeContext.Beers.Attach(beer);
            //Aquí indicamos que la entidad (beer) va a ser modificada
            _storeContext.Beers.Entry(beer).State = EntityState.Modified;
            //con el Save() se realizan los cambios
        }

        public void Delete(Beer beer)
            => _storeContext.Remove(beer);

        public async Task Save()
            => await _storeContext.SaveChangesAsync();

        public IEnumerable<Beer> Search(Func<Beer, bool> filter) =>
            _storeContext.Beers.Where(filter).ToList();
    }
}
