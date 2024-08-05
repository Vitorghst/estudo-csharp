public class AuthService
{
    private readonly MeuDbContext _context;

    public AuthService(MeuDbContext context)
    {
        _context = context;
    }

    public bool IsValidUser(string username, string password)
    {
        return _context.Usuarios.Any(u => u.Username == username && u.Password == password);
    }

    public User GetUser(string username)
    {
        return _context.Usuarios.FirstOrDefault(u => u.Username == username);
    }

    public bool AddUser(string username, string password)
    {
        if (_context.Usuarios.Any(u => u.Username == username))
        {
            return false; // Usuário já existe
        }

        var newUser = new User
        {
            Username = username,
            Password = password
        };

        _context.Usuarios.Add(newUser);
        _context.SaveChanges();

        return true; // Usuário adicionado com sucesso
    }
}
