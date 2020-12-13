using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using net_project_Revista.Data;
using net_project_Revista.Models;
using net_project_Revista.ViewModels;

namespace net_project_Revista.Pages.MovieFavourites
{
    [Authorize]
    public class MovieFavouritesModel : PageModel
    {
        private readonly MovieDbContext _db;

        public MovieFavouritesModel(MovieDbContext db)
        {
            _db = db;
        }

        public Favourite Favourite { get; set; }
        public FavouriteMovie FavouriteMovie { get; set; }
        public int MovieId { get; set; }

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
        }

        public void OnPost(int id)
        {
            FavouriteMovie = _db.FavouriteMovies
                .Where(movie => movie.MovieId == id && movie.FavouriteId == (int)HttpContext.Session.GetInt32("favouriteId"))
                .FirstOrDefault();

            _db.FavouriteMovies.Remove(FavouriteMovie);
            _db.SaveChanges();

            OnGet();
        }

    }
}
