using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Movie Movie { get; private set; }

        public moviedetailsModel(MovieDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }
        public void OnPost(MovieVM testMovie)
        {
            Movie = _db.Movies.Where(movie => movie.Id == testMovie.Id).FirstOrDefault();
        }

    }
}