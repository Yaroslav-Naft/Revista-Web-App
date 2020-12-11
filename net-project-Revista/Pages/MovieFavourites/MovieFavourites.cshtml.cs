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
        public string posterpath { get; set; }
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
        }

        public void OnPost()
        {
        }

    }
}
