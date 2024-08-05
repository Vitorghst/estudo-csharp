using Microsoft.AspNetCore.Mvc;
using ListApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MenuApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly MeuDbContext _context;

        private readonly MenuService _menuService;

        // public MenuController(MeuDbContext context)
        // {
        //     _context = context;
        // }

        public MenuController(MenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MenuItem>> GetMenu()
        {
            var menuItems = _menuService.getMenu();
            return Ok(menuItems);
        }

        [HttpPost("AddItem")]
        public IActionResult Item(MenuItem credentials)
        {
            if (credentials == null)
            {
                return BadRequest("Invalid data.");
            }

            _menuService.AddItem(credentials);

            return CreatedAtAction(nameof(Item), new { id = credentials.Id }, credentials);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var menuItem = _menuService.GetItemById(id);
            if (menuItem == null)
            {
                return NotFound($"O item com id {id} não foi encontrado.");
            }

            _menuService.RemoveItem(menuItem);

            return Ok($"O item {id} foi excluído com sucesso.");
        }


        [HttpPut("{id}")]
        public IActionResult Edit(int id, MenuItem credentials)
        {
            if (id != credentials.Id)
            {
                return BadRequest("O ID fornecido não corresponde ao ID do item.");
            }

            var menuItemId = _menuService.GetItemById(id);
            var menuItem = credentials;
            if (menuItem == null)
            {
                return NotFound();
            }

            // Atualizar as propriedades do item encontrado
            _menuService.EditItem(menuItemId, menuItem);


            return Ok($"O item {id} foi atualizado com sucesso.");
        }


    }
}
