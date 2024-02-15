using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                connectionString:
                @"Data Source=DEVELOPERKIT;Initial Catalog=ReCarDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        public DbSet<Entities.Concrete.Car> Car { get; set; }
        public DbSet<Entities.Concrete.Color> Color { get; set; }
        public DbSet<Entities.Concrete.Brand> Brand { get; set; }

    }
}
