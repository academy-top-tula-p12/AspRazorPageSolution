using Microsoft.EntityFrameworkCore;

namespace AspRPFlightsApp.Models
{
    public class FlightsAppContext :DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Airport> Airports { get; set; } = null!;

        public FlightsAppContext(DbContextOptions<FlightsAppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().ToTable("Cities");

            modelBuilder.Entity<Airport>().ToTable("Airports");
        }

    }
}
