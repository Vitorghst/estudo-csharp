using Microsoft.AspNetCore.Mvc;
using ListApi.Models;
using System.Collections.Generic;
using ListApi.Migrations;

namespace ListApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HorariosController : ControllerBase
    {
        public readonly MeuDbContext _context;

         public HorariosController(MeuDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Horario>> Get()
        {
            var horariosList = _context.Horarios.ToList();
            return Ok(horariosList);
        }
    }
}