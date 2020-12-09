using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
       
        public IndexModel(IMovieVMService movieVMService, MovieDbContext db)
        {
            _movieVMService = movieVMService;
            _db = db;
        }

        public MovieIndexVM MovieIndex = new MovieIndexVM();

        public ICollection<Movie> Movies { get; private set; }

        public void OnGet(MovieIndexVM movieIndex)
        {
            MovieIndex = _movieVMService.GetMoviesVM(movieIndex.CategoriesFilterApplied);
        }
    }
}
