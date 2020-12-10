using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using net_project_Revista.Data;
using net_project_Revista.Models;
using net_project_Revista.ViewModels;

namespace net_project_Revista.Pages.MovieDetails
{
    public class moviedetailsModel : PageModel
    {
        private readonly MovieDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public Favourite Favourite { get; set; }

        public Movie Movie { get; private set; }

<<<<<<< HEAD
        public moviedetailsModel(MovieDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
=======
        public string PosterPath { get; private set; }

        public moviedetailsModel(MovieDbContext db)
>>>>>>> master
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public void OnGet(MovieVM testMovie)
        {
            Movie = _db.Movies.Where(movie => movie.Id == testMovie.Id).FirstOrDefault();
<<<<<<< HEAD
            Movie.PosterPath = "https://image.tmdb.org/t/p/w500" + Movie.PosterPath;
        }

        public void OnPost(MovieVM testMovie)
        {          
            int? favouriteId = HttpContext.Session.GetInt32("favouriteId");
            bool isUser = _signInManager.IsSignedIn(User);
            string userId = null;

            if (isUser)
            {
                userId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;
            }

            Favourite fav;

            if (favouriteId == null)
            {
                fav = new Favourite(userId, DateTime.Now);
                _db.Favourites.Add(fav);
                _db.SaveChanges();
                favouriteId = fav.Id;
            }
            else
            {
                Favourite = _db.Favourites
                    .Include(f => f.FavouriteMovies)
                    .ThenInclude(fm => fm.Movie)
                    .Where(f => f.Id == (int)HttpContext.Session.GetInt32("favouriteId"))
                    .FirstOrDefault();

                if(Favourite.UserId != userId)
                {
                    fav = new Favourite(userId, DateTime.Now);
                    _db.Favourites.Add(fav);
                    _db.SaveChanges();
                    favouriteId = fav.Id;
                }
            }

            FavouriteMovie fm;

            fm = _db.FavouriteMovies.Where(fm => fm.FavouriteId == favouriteId && fm.MovieId == testMovie.Id).FirstOrDefault();

            if (fm == null)
            {
                fm = new FavouriteMovie((int)favouriteId, testMovie.Id);
                _db.FavouriteMovies.Add(fm);
            }

            _db.SaveChanges();
            Movie = _db.Movies.Where(movie => movie.Id == testMovie.Id).FirstOrDefault();
            Movie.PosterPath = "https://image.tmdb.org/t/p/w500" + Movie.PosterPath;
            HttpContext.Session.SetInt32("favouriteId", (int)favouriteId);
=======
            PosterPath = "https://images.tmdb.org/t/p/w500" + Movie.PosterPath;
        }
        public void OnPost()
        {

>>>>>>> master
        }

    }
}