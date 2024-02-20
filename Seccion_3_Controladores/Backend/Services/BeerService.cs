using AutoMapper;
using Backend.DTOs;
using Backend.Models;
using Backend.Repository;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services
{
    public class BeerService : ICommonService<BeerDto, BeerInsertDto, BeerUpdateDto>
    {
        private IRepository<Beer> _beerRepository;
        private IMapper _mapper;
        public List<string> Errors { get; }

        public BeerService(
            IRepository<Beer> beerRepository,
            IMapper mapper
        )
        {
            _beerRepository = beerRepository;
            _mapper = mapper;
            Errors = new List<string>();
        }

        public async Task<IEnumerable<BeerDto>> Get()
        {
            var beers = await _beerRepository.Get();

            //En vez de hacerlo así...
            /*
            return beers.Select(b => new BeerDto
            {
                Id = b.BeerID,
                Name = b.Name,
                Alcohol = b.Alcohol,
                BrandID = b.BrandID
            });
            */
            //Ahora usaremos mapper
            return beers.Select(b => _mapper.Map<BeerDto>(b));
        }

        public async Task<BeerDto> GetById(int id)
        {
            var beer = await _beerRepository.GetById(id);

            if (beer != null)
            {
                //En vez de hacerlo así...
                /*
                var beerDto = new BeerDto
                {
                    Id = beer.BeerID,
                    Name = beer.Name,
                    Alcohol = beer.Alcohol,
                    BrandID = beer.BrandID
                };
                */
                //... ahora usaremos mapper
                var beerDto = _mapper.Map<BeerDto>(beer);

                return beerDto;
            }

            return null;
        }

        public async Task<BeerDto> Add(BeerInsertDto beerInsertDto)
        {

            /*
            var beer = new Beer()
            {
                Name = beerInsertDto.Name,
                BrandID = beerInsertDto.BrandID,
                Alcohol = beerInsertDto.Alcohol
            };
            */
            //En vez de hacer lo anterior manualmente,
            //Ahora lo hace automaticamente mapper
            var beer = _mapper.Map<Beer>(beerInsertDto);

            //Aquí todavía no se hace el insert en la debe
            //solo le avisa a entityFramework que va a  haber un insert
            await _beerRepository.Add(beer);
            //Aquí ya se ven reflejados los cambios en la base de datos
            await _beerRepository.Save();

            /*
            var beerDto = new BeerDto
            {
                Id = beer.BeerID,
                Name = beer.Name,
                Alcohol = beer.Alcohol,
                BrandID = beer.BrandID
            };
            */
            var beerDto = _mapper.Map<BeerDto>(beer);

            return beerDto;
        }

        public async Task<BeerDto> Update(int id, BeerUpdateDto beerUpdateDto)
        {
            var beer = await _beerRepository.GetById(id);

            if (beer != null)
            {
                //En vez de hacer esto así...
                /*
                beer.Name = beerUpdateDto.Name;
                beer.Alcohol = beerUpdateDto.Alcohol;
                beer.BrandID = beerUpdateDto.BrandID;
                */
                //... lo haremos asi. Y respeta el Id/BeerID
                beer = _mapper.Map<BeerUpdateDto, Beer>(beerUpdateDto, beer);

                //aquí no tiene await porque solo está haciendo un Atach
                //de la entidad beer, 
                _beerRepository.Update(beer);
                await _beerRepository.Save();

                //En vez de hacerlo así...
                /*
                var beerDto = new BeerDto
                {
                    Id = beer.BeerID,
                    Name = beer.Name,
                    Alcohol = beer.Alcohol,
                    BrandID = beer.BrandID
                };
                */

                //... ahora usaremos mapper
                var beerDto = _mapper.Map<BeerDto>(beer);

                return beerDto;
            }

            return null;
        }

        public async Task<BeerDto> Delete(int id)
        {
            var beer = await _beerRepository.GetById(id);

            if (beer != null)
            {
                //guardo primero el dto porque se va a eliminar y ya no lo recuperaría
                //Y en vez de hacerlo asi...
                /*
                var beerDto = new BeerDto
                {
                    Id = beer.BeerID,
                    Name = beer.Name,
                    Alcohol = beer.Alcohol,
                    BrandID = beer.BrandID
                };
                */
                //... ahora lo haremos así con mapper
                var beerDto = _mapper.Map<BeerDto>(beer);

                _beerRepository.Delete(beer);
                await _beerRepository.Save();

                return beerDto;
            }

            return null;
        }

        public bool Validate(BeerInsertDto beerInsertDto)
        {
            if (_beerRepository.Search(b => b.Name == beerInsertDto.Name).Count() > 0)
            {
                Errors.Add("Ese nombre de cerveza ya existe, escribe otro");
                return false;
            }
            
            return true;
        }

        public bool Validate(BeerUpdateDto beerUpdateDto)
        {
            if (_beerRepository.Search(b => b.Name == beerUpdateDto.Name
                && beerUpdateDto.Id != b.BeerID).Count() > 0)
            {
                Errors.Add("Ese nombre de cerveza ya existe, escribe otro");
                return false;
            }

            return true;
        }

    }
}
