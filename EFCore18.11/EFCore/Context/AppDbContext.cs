using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Context;

public class AppDbContext:DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=EFCore;TrustServerCertificate=True;User Id=SA;Password=reallyStrongPwd123;");
        base.OnConfiguring(optionsBuilder);
    }
}