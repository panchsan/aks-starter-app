using Docker_compose_web_app.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Docker_compose_web_app.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            try
            {
                var databasecreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (databasecreator != null)
                {
                    if (!databasecreator.CanConnect()) databasecreator.Create();
                    if (!databasecreator.HasTables()) databasecreator.CreateTables();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(c => c.Id);
            });

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id=1,
                    Name = "Speed",
                    Actors= "Keanu Reeves,Dennis Hopper,Sandra Bullock"
                },
                new Movie
                {
                    Id = 2,
                    Name = "First Blood",
                    Actors = "Sylvester Stallone,Brian Dennehy,Richard Crenna"
                },
                new Movie
                {
                    Id = 3,
                    Name = "The Bourne Identity",
                    Actors = "Franka Potente,Matt Damon,Chris Cooper"
                },
                new Movie
                {
                    Id = 4,
                    Name = "Top Gun: Maverick",
                    Actors= "Tom Cruise,Jennifer Connelly,Miles Teller"
                },
                new Movie
                {
                    Id = 5,
                    Name = "Casino Royale",
                    Actors = "Daniel Craig,Eva Green,Judi Dench"
                }

            );
        }
    }
}
