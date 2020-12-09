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

            if (!await movieContext.Genres.AnyAsync())
            {
                await movieContext.Genres.AddRangeAsync(
                    GetPreconfiguredGenres());

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

        static IEnumerable<Genre> GetPreconfiguredGenres()
        {
            return new List<Genre>()
            {
                new Genre(28, "Action"),
                new Genre(12, "Adventure"),
                new Genre(16, "Animation"),
                new Genre(35, "Comedy"),
                new Genre(80, "Crime"),
                new Genre(99, "Documentary"),
                new Genre(18, "Drama"),
                new Genre(10751, "Family"),
                new Genre(14, "Fantasy"),
                new Genre(36, "History"),
                new Genre(27, "Horror"),
                new Genre(10402, "Music"),
                new Genre(9648, "Mystery"),
                new Genre(10749, "Romance"),
                new Genre(878, "Science Fiction"),
                new Genre(10770, "TV Movie"),
                new Genre(53, "Thriller"),
                new Genre(10752, "War"),
                new Genre(37, "Western")
            };
        }
    }
}
