using ListApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

public class MenuService
{
    private readonly MeuDbContext _context;

    public MenuService(MeuDbContext context)
    {
        _context = context;
    }

    public List<MenuItem> getMenu()
    {
        return _context.MenuItems.ToList();
    }

    public List<Horario> getHorario()
    {
        return _context.Horarios.ToList();
    }

    public async Task<IEnumerable<object>> GetMenuItemsAsync()
    {
        var menuItems = await _context.MenuItems.Select(item => new
        {   
            item.Id,
            item.Name,
            item.Description,
            item.Price,
            item.Category,
            ImagePath = item.ImagePath != null ? Path.Combine("http://localhost:5110", item.ImagePath) : null
        }).ToListAsync();

        return menuItems;
    }

    public void AddItem(MenuItem menuItem)
    {
        _context.MenuItems.Add(menuItem);
        _context.SaveChanges();

    }

    public MenuItem GetItemById(int id)
    {
        return _context.MenuItems.Find(id);
    }

    public void RemoveItem(MenuItem menuItem)
    {
        _context.MenuItems.Remove(menuItem);
        _context.SaveChanges();
    }


    public void EditItem(MenuItem menuItemId, MenuItem menuItem)
    {   
        _context.Entry(menuItemId).CurrentValues.SetValues(menuItem);
        _context.SaveChanges();
    }

}