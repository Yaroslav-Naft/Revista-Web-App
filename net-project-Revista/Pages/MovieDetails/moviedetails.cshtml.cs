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

        public string Title { get; private set; }
        public moviedetailsModel(MovieDbContext db)
        {
            _db = db;
        }

        public List<Movie> Movie = new List<Movie>();

        public void OnGet()
        {
            //Movie = _db.Movies.Select(
            //    m => new Movie
            //    {
            //        Title = m.title
            //    }
            //    ).ToList();
        }
        //Need to add Movies testMovie inside Onpost

        //When you press on post from from movies page
        //it directs you to the onpost of this page
        public IActionResult OnPost(MovieVM testMovie)
        {
            //if(testMovie?.Id == null)
            //{
            //    return RedirectToPage("/Index");
            //}
            //Add If statement to redirect to home page
            //if item id is null

            //Otherwise if there is an id
            //redirect to correct page
            //redirect to page makes you
            //do the onget method of this pase
            return RedirectToPage();
        }

    }
}