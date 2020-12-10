using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using net_project_Revista.Data;
using net_project_Revista.Interfaces;
using net_project_Revista.Models;
using net_project_Revista.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IMovieVMService _movieVMService;
        private readonly MovieDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IndexModel(IMovieVMService movieVMService, MovieDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _movieVMService = movieVMService;
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public Favourite Favourite { get; set; }

        public MovieIndexVM MovieIndex = new MovieIndexVM();

        public ICollection<Movie> Movies { get; private set; }

        public void OnGet(MovieIndexVM movieIndex)
        {
            int? favouriteId = HttpContext.Session.GetInt32("favouriteId");
            bool isUser = _signInManager.IsSignedIn(User);

            if (isUser && favouriteId == null)
            {
                string userId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;

                Favourite = _db.Favourites
                    .Include(f => f.FavouriteMovies)
                    .ThenInclude(fm => fm.Movie)
                    .Where(f => f.UserId == userId)
                    .FirstOrDefault();
                if (Favourite != null)
                {
                    HttpContext.Session.SetInt32("favouriteId", Favourite.Id);
                }
            }

            MovieIndex = _movieVMService.GetMoviesVM(movieIndex.CategoriesFilterApplied);
        }
    }
}
