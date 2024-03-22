using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DataAccess.Concrete.EntityFramework;

public class ReCapContext : DbContext
{
    public DbSet<Car> Car { get; set; }
    public DbSet<Color> Color { get; set; }
    public DbSet<Brand> Brand { get; set; }
    public DbSet<Rental> Rental { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Customer> Customer { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=DEVELOPERKIT;Initial Catalog=ReCarDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Car>().ToTable("Cars");
        //modelBuilder.Entity<Car>().Property(c => c.Description).HasColumnName("CarName");
        //modelBuilder.Entity<Car>().Property(c => c.ModelYear).HasColumnName("Year");
        //modelBuilder.Entity<Car>().Property(c => c.DailyPrice).HasColumnName("Price");

        var rentDate = modelBuilder.Entity<Rental>();
        rentDate.Property(f => f.RentDate).HasColumnType("smalldatetime");

        var returnDate = modelBuilder.Entity<Rental>();
        returnDate.Property(f => f.ReturnDate).HasColumnType("smalldatetime");

        base.OnModelCreating(modelBuilder);
    }
}