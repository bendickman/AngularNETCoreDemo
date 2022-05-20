using AngularNetCoreDemoBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularNetCoreDemoBackend.Controllers
{
    [ApiController]
    [Route("api")]
    public class HeroController : Controller
    {
        [HttpGet(Name = "GetHeroes")]
        [Route("heroes")]
        public IEnumerable<Hero> List()
        {
            return GetHeroes();
        }

        [HttpGet(Name = "GetHeroes")]
        [Route("hero/{id}")]
        public Hero Get(int id)
        {
            return GetHeroes()
                .FirstOrDefault(h => h.Id == id);
        }

        private IEnumerable<Hero> GetHeroes()
        {
            return new List<Hero>
            {
                new Hero{ Id = 12, Name = "Dr. Nice"},
                new Hero{ Id = 13, Name = "Bombasto"},
                new Hero{ Id = 14, Name = "Celeritas"},
                new Hero{ Id = 15, Name = "Magneta"},
                new Hero{ Id = 16, Name = "RubberMan"},
                new Hero{ Id = 17, Name = "Dynama"},
                new Hero{ Id = 18, Name = "Dr. IQ"},
                new Hero{ Id = 19, Name = "Magma"},
                new Hero{ Id = 20, Name = "Tornado"},
                new Hero{ Id = 21, Name = "Backend Man"},
            };
        }
    }
}
