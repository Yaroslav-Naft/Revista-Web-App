using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using net_project_Revista.Data;
using net_project_Revista.Models;
using net_project_Revista.ViewModels;

namespace net_project_Revista.Pages.MovieFavourites
{
    public class moviefavouritesModel : PageModel
    {
        private readonly MovieDbContext _db;
        public Favourite Favourite { get; set; }
        public string PosterPath { get; private set; }
        public moviefavouritesModel(MovieDbContext db)
        {
            _db = db;
        }
        public ICollection<FavouriteMovie> FavouriteMoviesList { get; private set; }

        public void OnGet()
        {
         //Get Favourite movies from database
         Favourite = _db.Favourites
        .Include(c => c.FavouriteMovies)
        .ThenInclude(c => c.Movie)
        .Where(c => c.Id == (int)HttpContext.Session.GetInt32("favouriteId"))
        .FirstOrDefault();



            //Set the movies variable to a collection
            FavouriteMoviesList = Favourite.FavouriteMovies;


            //how do you directly get data from database not how you get from a post
            //Movie = _db.FavouriteMovies.Where(a => a.MovieId == 1).Single();
            //Movie = _db.favouriteMovies
            //     .Include(f => f.FavouriteMovies)
            //     .ThenInclude(fm => fm.Movie)
            //     .Where(f => f.UserId == userId)
            //     .FirstOrDefault();


            //var fav = new MovieIndexVM()
            //{
            //    Movies = movies.Select(m => new MovieVM
            //    {
            //        Id = m.Id,
            //        Title = m.Title,
            //        Overview = m.Overview,
            //        ReleaseDate = m.ReleaseDate.ToString("MMMM dd, yyyy"),
            //        PosterPath = "https://image.tmdb.org/t/p/w500" + m.PosterPath
            //    }).ToList(),
            //    Categories = GetCategories().ToList()
            //};
        }

        public void OnPost()
        {
            //Movie = _db.Movies.Where(movie => movie.Id == testMovie.Id).FirstOrDefault();
            //PosterPath = "https://images.tmdb.org/t/p/w500" + Movie.PosterPath;
        }

    }
}
