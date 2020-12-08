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
    }
}
