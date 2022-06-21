using Basketball_Workshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Basketball_Workshop
{
    public class BasketballContext : DbContext
    {
        public DbSet<Position> Position { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // three things to specify: connection string, we tell the options builder to use that connection string
            // and then we feed our optionsBuilder into the parent class's configuring method
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=BasketballDB_Summer2022;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this is where we will add our seed data (the data our database starts with)
            modelBuilder.Entity<Position>().HasData(
                new Position() { Id = 1, Name = "Point Guard" }, 
                new Position() { Id = 2, Name = "Shooting Guard" },
                new Position() { Id = 3, Name = "Small Forward"},
                new Position() { Id = 4, Name = "Power Forward"},
                new Position() { Id = 5, Name = "Center" }
                );
        }
    }
}
