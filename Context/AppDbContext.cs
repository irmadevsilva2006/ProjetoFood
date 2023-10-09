using ProjetoFood.Models;
using Microsoft.EntityFrameworkCore;
namespace ProjetoFood.Context
{

public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        {
        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Item> Item { get; set; }
    }
}