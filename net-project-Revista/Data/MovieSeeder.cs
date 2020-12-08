using Microsoft.EntityFrameworkCore;
using net_project_Revista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Data
{
    public class MovieSeeder
    {
        public static async Task SeedAsync(MovieDbContext movieContext)
        {
            if(!await movieContext.MovieCategories.AnyAsync())
            {
                await movieContext.MovieCategories.AddRangeAsync(
                    GetPreconfiguredMovieCategories());

                await movieContext.SaveChangesAsync();
            }

            if (!await movieContext.MovieGenres.AnyAsync())
            {
                await movieContext.MovieGenres.AddRangeAsync(
                    GetPreconfiguredMovieGenres());

                await movieContext.SaveChangesAsync();
            }
        }

        static IEnumerable<MovieCategory> GetPreconfiguredMovieCategories()
        {
            return new List<MovieCategory>()
            {
                new MovieCategory("Popular"),
                new MovieCategory("Top Rated"),
                new MovieCategory("Now Playing"),
                new MovieCategory("Upcoming")
            };
        }

        static IEnumerable<MovieGenre> GetPreconfiguredMovieGenres()
        {
            return new List<MovieGenre>()
            {
                new MovieGenre(28, "Action"),
                new MovieGenre(12, "Adventure"),
                new MovieGenre(16, "Animation"),
                new MovieGenre(35, "Comedy"),
                new MovieGenre(80, "Crime"),
                new MovieGenre(99, "Documentary"),
                new MovieGenre(18, "Drama"),
                new MovieGenre(10751, "Family"),
                new MovieGenre(14, "Fantasy"),
                new MovieGenre(36, "History"),
                new MovieGenre(27, "Horror"),
                new MovieGenre(10402, "Music"),
                new MovieGenre(9648, "Mystery"),
                new MovieGenre(10749, "Romance"),
                new MovieGenre(878, "Science Fiction"),
                new MovieGenre(10770, "TV Movie"),
                new MovieGenre(53, "Thriller"),
                new MovieGenre(10752, "War"),
                new MovieGenre(37, "Western")
            };
        }
    }
}
