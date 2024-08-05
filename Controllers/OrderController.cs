using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListApi.Models;

namespace Orders.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly MeuDbContext _context;

        public OrderController(MeuDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            var orders = _context.Orders
                                 .Include(o => o.OrderItems) // Eager loading dos OrderItems
                                 .ToList();

            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> PostOrder(Order order)
        {
            if (order == null)
            {
                return BadRequest("Order cannot be null");
            }

            // Assegurando que a referência de Order em cada OrderItem está correta
            if (order.OrderItems != null)
            {
                foreach (var item in order.OrderItems)
                {
                    item.Order = order;
                }
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, order);
        }
    }
}
