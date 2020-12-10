using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using net_project_Revista.Data;
using net_project_Revista.Models;

namespace net_project_Revista.Pages.MovieFavourites
{
    public class moviefavouritesModel : PageModel
    {
        private readonly MovieDbContext _db;
        public Movie Movie { get; private set; }
        public string PosterPath { get; private set; }
        public moviefavouritesModel(MovieDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {



        }

        public void OnPost(Movie testMovie)
        {
            Movie = _db.Movies.Where(movie => movie.Id == testMovie.Id).FirstOrDefault();
            PosterPath = "https://images.tmdb.org/t/p/w500" + Movie.PosterPath;
        }

    }
}
