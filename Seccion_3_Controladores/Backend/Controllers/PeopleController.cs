using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleService _peopleService;

        public PeopleController( [FromKeyedServices("peopleService2")] IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet("all")]
        public List<People> GetPeople() => Repository.People;

        [HttpGet("{id}")]
        public ActionResult<People> Get(int id) { 
            var people = Repository.People.FirstOrDefault(p => p.Id == id);
            if (people == null)
            {
                return NotFound();
            }
            return Ok(people);
        }

        [HttpPost]
        public IActionResult Add(People people)
        {
            if (!_peopleService.Validate(people))
            {
                return BadRequest();
            }

            Repository.People.Add(people);
            return NoContent();
        }

        [HttpGet("search/{search}")]
        public List<People> Get(string search) =>
            Repository.People.Where(p => p.Name.Contains(search)).ToList();

        [HttpGet("searchopen/{search}")]
        public List<People> GetOpen(string search) =>
            Repository.People.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();


    }

    public class Repository
    {
        public static List<People> People = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Panda Rojo",
                Birthdate = new DateTime(1999, 10, 01)
            },
            new People()
            {
                Id = 2,
                Name = "Panda Azul",
                Birthdate = new DateTime(1998, 09, 02)
            },
            new People()
            {
                Id = 3,
                Name = "Panda Verde",
                Birthdate = new DateTime(1997, 08, 03)
            },
            new People()
            {
                Id = 4,
                Name = "Panda Amarillo",
                Birthdate = new DateTime(1999, 10, 01)
            },
            new People()
            {
                Id = 5,
                Name = "Panda Morado",
                Birthdate = new DateTime(1998, 09, 02)
            },
            new People()
            {
                Id = 6,
                Name = "Panda Cafe",
                Birthdate = new DateTime(1997, 08, 03)
            },
        };
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }

}
