using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private IRandomService _randomServiceSingleton;
        private IRandomService _randomServiceScoped;
        private IRandomService _randomServiceTransient;

        private IRandomService _randomServiceSingleton2;
        private IRandomService _randomServiceScoped2;
        private IRandomService _randomServiceTransient2;

        public RandomController(
            [FromKeyedServices("randomSingleton")] IRandomService randomServiceSingleton,
            [FromKeyedServices("randomScoped")] IRandomService randomServiceScoped,
            [FromKeyedServices("randomTransient")] IRandomService randomServiceTransient,
            [FromKeyedServices("randomSingleton")] IRandomService randomServiceSingleton2,
            [FromKeyedServices("randomScoped")] IRandomService randomServiceScoped2,
            [FromKeyedServices("randomTransient")] IRandomService randomServiceTransient2
        )
        {
            _randomServiceSingleton = randomServiceSingleton;
            _randomServiceScoped = randomServiceScoped;
            _randomServiceTransient = randomServiceTransient;
            _randomServiceSingleton2 = randomServiceSingleton2;
            _randomServiceScoped2 = randomServiceScoped2;
            _randomServiceTransient2 = randomServiceTransient2;
        }

        [HttpGet]
        public ActionResult<Dictionary<string, int>> Get()
        {
            var result = new Dictionary<string, int>();
            result.Add("Singleton 1", _randomServiceSingleton.Value);
            result.Add("Scoped 1", _randomServiceScoped.Value);
            result.Add("Transient 1", _randomServiceTransient.Value);

            result.Add("Singleton 2", _randomServiceSingleton2.Value);
            result.Add("Scoped 2", _randomServiceScoped2.Value);
            result.Add("Transient 2", _randomServiceTransient2.Value);

            return result;

        }

    }
}
