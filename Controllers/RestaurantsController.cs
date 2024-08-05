using Microsoft.AspNetCore.Mvc;
using ListApi;
using System.Collections.Generic;
using ListApi.Models;

namespace ListApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {


        private readonly MeuDbContext _context;

        public RestaurantsController(MeuDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> GetRestaurants()
        {
           var restaurants = _context.Restaurant.ToList();
            return Ok(restaurants);
        }
    }
}