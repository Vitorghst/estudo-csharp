using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Congelante", "Revigorante", "Frio", "Fresco", "Ameno", "Quente", "Ameno", "Quente", "Abrasador", "Escaldante"
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProductsController")]
        public IActionResult Get()
        {
            var forecasts = Enumerable.Range(1, 5).Select(index => new
            {
                Date = DateTime.Now.AddDays(index).ToString("yyyy-MM-dd"),
                TemperatureC = Random.Shared.Next(-20, 55),
                TemperatureF = 32 + (int)((Random.Shared.NextDouble() * 9 / 5) * 100) / 100.0, // Convers�o de C para F
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });

            return Ok(forecasts);
        }
    }
}
