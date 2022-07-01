using Basketball_Workshop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Basketball_Workshop
{
    public class BasketballContext : IdentityDbContext
    {
        public DbSet<Position> Positions { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
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
            //modelBuilder.Entity<Position>().HasData(
            //    new Position() { Id = 1, Name = "Point Guard" }, 
            //    new Position() { Id = 2, Name = "Shooting Guard" },
            //    new Position() { Id = 3, Name = "Small Forward"},
            //    new Position() { Id = 4, Name = "Power Forward"},
            //    new Position() { Id = 5, Name = "Center" }
            //    );
            //modelBuilder.Entity<Player>().HasData(
            //    new Player() { Id = 1, TeamId = 1, Name = "Kevin Love", PPG = 10.4, IsRetired = false},
            //    new Player() { Id = 2, TeamId = 1, Name = "Colin Sexton", PPG = 19.3, IsRetired = false }
            //    );
            //modelBuilder.Entity<PlayerPosition>().HasData(
            //    new PlayerPosition() { Id = 1, PlayerId = 1, PositionId = 4},
            //    new PlayerPosition() { Id = 2, PlayerId = 1, PositionId = 5},
            //    new PlayerPosition() { Id = 3, PlayerId = 2, PositionId = 1},
            //    new PlayerPosition() { Id = 4, PlayerId = 2, PositionId = 2}
            //    );
            //modelBuilder.Entity<Coach>().HasData(
            //    new Coach() { Id = 1, Name = "J. B. Bickerstaff", FavoriteFood = "Pierogies", StartYear = DateTime.Now, Wins = 44, Losses = 38 }
            //    );
            //modelBuilder.Entity<Team>().HasData(
            //    new Team() { Id = 1, CoachId = 1, City = "Cleveland", Name = "Cavs", Mascot = "Moondog"}
            //    );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Basketball_Workshop.Models.TempPlayer>? TempPlayer { get; set; }
    }
}
