using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using net_project_Revista.Data;
using net_project_Revista.Models;
using net_project_Revista.ViewModels;

namespace net_project_Revista.Pages.MovieDetails
{
    public class moviedetailsModel : PageModel
    {
        private readonly MovieDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public Movie Movie { get; private set; }

        public moviedetailsModel(MovieDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public void OnGet(MovieVM testMovie)
        {
            Movie = _db.Movies.Where(movie => movie.Id == testMovie.Id).FirstOrDefault();
            Movie.PosterPath = "https://image.tmdb.org/t/p/w500" + Movie.PosterPath;
        }

        public void OnPost(MovieVM testMovie)
        {
            int? favouriteId = HttpContext.Session.GetInt32("favouriteId");
            bool isUser = User.Identity.IsAuthenticated;
            string userId = null;

            if (isUser)
            {
                userId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;
            }

        }

    }
}