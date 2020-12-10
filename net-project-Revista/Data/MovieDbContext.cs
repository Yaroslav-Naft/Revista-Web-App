using Microsoft.EntityFrameworkCore;
using net_project_Revista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<FavouriteMovie> FavouriteMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavouriteMovie>()
                .HasKey(cp => new { cp.FavouriteId, cp.MovieId });

            modelBuilder.Entity<FavouriteMovie>()
                .HasOne(cp => cp.Favourite)
                .WithMany(c => c.FavouriteMovies)
                .HasForeignKey(fk => new { fk.FavouriteId });

            modelBuilder.Entity<FavouriteMovie>()
                .HasOne(cp => cp.Movie)
                .WithMany(p => p.FavouriteMovies)
                .HasForeignKey(fk => new { fk.MovieId });

            //use to manually define composite and forgein keys
            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => new {mg.MovieId, mg.GenreId });

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(fk => new { fk.MovieId });

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(g => g.MovieGenres)
                .HasForeignKey(fk => new { fk.GenreId });
        }
    }
}
