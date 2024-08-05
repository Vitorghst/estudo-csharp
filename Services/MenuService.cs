using ListApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;

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