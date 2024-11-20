using eTickets_2.Models;
using Microsoft.EntityFrameworkCore;
namespace eTickets_2.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>().HasKey(
                AM => new
                {
                    AM.ActorId,
                    AM.MovieId
                });

            modelBuilder.Entity<ActorMovie>()
                .HasOne(m => m.movie)
                .WithMany(am => am.Actor_Movie)
                .HasForeignKey(am => am.MovieId);
            modelBuilder.Entity<ActorMovie>()
                .HasOne(a => a.actor)
                .WithMany(am => am.Actor_Movie)
                .HasForeignKey(a => a.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> actors { get; set; }
        public DbSet<Cinema> cinemas { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Producer> producers { get; set; }
        public DbSet<ActorMovie> actorMovies { get; set; }
    }
}
