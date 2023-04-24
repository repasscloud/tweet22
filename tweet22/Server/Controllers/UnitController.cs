using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tweet22.Shared;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tweet22.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        public IList<Unit> Units => new List<Unit>
        {
            new Unit { Id = 1, Title = "Knight", Attack = 10, Defense = 10, BananaCost = 100 },
            new Unit { Id = 2, Title = "Archer", Attack = 15, Defense = 5, BananaCost = 150 },
            new Unit { Id = 3, Title = "Mage", Attack = 20, Defense = 1, BananaCost = 200 },
        };

        // GET: /<controller>/
        public IActionResult GetUnits()
        {
            return Ok(Units);
        }
    }
}

