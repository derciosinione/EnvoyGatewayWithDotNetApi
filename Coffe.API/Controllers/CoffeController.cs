using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Coffe.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeController : ControllerBase
    {
        private static readonly string[] Coffees = new[]
        {
            "Flat White", "Long Black", "Latte", "Americano", "Cappuccino"
        };

        private readonly ILogger<CoffeController> _logger;

        public CoffeController(ILogger<CoffeController> logger)
        {
            _logger = logger;
        }
    
        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            
            return Ok(Coffees[rng.Next(Coffees.Length)]);
        }
    }
}
