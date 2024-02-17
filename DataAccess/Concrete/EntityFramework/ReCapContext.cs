using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class ReCapContext : DbContext
{
    public DbSet<Car> Car { get; set; }
    public DbSet<Color> Color { get; set; }
    public DbSet<Brand> Brand { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=DEVELOPERKIT;Initial Catalog=ReCarDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
    }
}