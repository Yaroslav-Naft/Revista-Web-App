using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using net_project_Revista.Data;
using net_project_Revista.Models;

namespace net_project_Revista.Pages
{

    public class moviedetailsModel : PageModel
    {
        private readonly MovieDbContext _db;

        public moviedetailsModel(MovieDbContext db)
        {
            _db = db;
        }

        public List<Movie> Movie = new List<Movie>();

        public void OnGet()
        {
            



        }

        //Need to add Movies testMovie inside Onpost
        public IActionResult OnPost(Movie testMovie)
        {
            if(testMovie?.Id == null)
            {
                return RedirectToPage("/Index");
            }
            //Add If statement to redirect to home page
            //if item id is null

            //Otherwise if there is an id
            //redirect to correct page
            return RedirectToPage();
        }

    }
}
