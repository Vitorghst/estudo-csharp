using ListApi.Models;
using Microsoft.EntityFrameworkCore;

public class MeuDbContext : DbContext
{
    public MeuDbContext(DbContextOptions<MeuDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Usuarios { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Restaurant> Restaurant  { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Horario> Horarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Username = "Maria da Penha",
                Password = "123",
                Permission = "B"
            },

             new User
            {
                Id = 2,
                Username = "Maik",
                Password = "123",
                Permission = "A"
            }
        );

        


         modelBuilder.Entity<MenuItem>().HasData(

            new MenuItem { Id = 1, ImagePath = "assets/images/foods/fries.png", Name = "Cachorro Quente Simples", Description = "Pão de leite, salsicha, tomate, maionese, ketchup e mostarda.", Price = 10, Category = "Cachorro Quente"  },
            new MenuItem { Id = 2, ImagePath = "assets/images/foods/hotduplo.png", Name = "HOT DOG TRADICIONAL DUPLO", Description = "Pão de leite, 02 salsicha, tomate, maionese, ketchup e mostarda.", Price = 2.5, Category = "Cachorro Quente" }
            // Adicione mais itens de menu conforme necessário
        );

        modelBuilder.Entity<Restaurant>().HasData(
            new Restaurant {
                    Id = 1,
                    Name = "FoodBoard",
                    Endereco = "Avenida Romário Martins 101 Centro",
                    Cidade = "Rolândia",
                    Estado = "PR",
                    Email = "foodboard@gmail.com",
                    Cep = "86601028",
                    Telefone = "433256-9661",
                    Celular = "4399859-9286",
                    Cnpj = "19.123.456/0001-12",
                    EntregaTempo = 40,
                    Retirada = "30",
                    PedidoMin = 8.5,
                    Frete = "9"
                }
        );


    }
}
