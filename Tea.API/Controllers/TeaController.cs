using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {
            "Green", "Peppermint", "Earl Grey", "English Breakfast", "Camomile"
        };

         private readonly ILogger<TeaController> _logger;

        public TeaController(ILogger<TeaController> logger)
        {
            _logger = logger;
        }
    
    
        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            
            return Ok(Teas[rng.Next(Teas.Length)]);
        }
    }
}