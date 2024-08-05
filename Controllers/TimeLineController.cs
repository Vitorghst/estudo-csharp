using ListApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace TimeLine.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TimeLineController : Controller

    {
        private readonly MeuDbContext _context;

        public TimeLineController(MeuDbContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public ActionResult<IEnumerable<Event>> GetEvent() 
        // {
        //     var eventItem = _context.Events.ToList();

        //     return Ok(eventItem);
        // }
    }
}