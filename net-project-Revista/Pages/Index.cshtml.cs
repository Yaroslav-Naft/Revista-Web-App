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
<<<<<<< HEAD
            MovieIndex = _movieVMService.GetMoviesVM(movieIndex.CategoriesFilterApplied);
=======
            //test with hard code movie
            Movies = new List<Movie>()
            {
                    new Movie("Jiu jitsu","Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ", DateTime.Now ,"Action, Fantasy, Science Fiction", 142, "/images/photo-1.jpg","Popular"),
                    new Movie("Uside Down Magic","Nory and her best friend Reina enter the Sage Academy for Magical Studies, where Nory’s unconventional powers land her in a class ", DateTime.Now ,"Family, Fantasy, TV Movie", 134, "/images/photo-2.jpg","Now Playing"),
                    new Movie("Joker","During the 1980s, a failed stand-up comedian is driven insane and turns to a life of crime and chaos in Gotham City while becoming ", DateTime.Now ,"Crime, Thriller, Drama", 220, "/images/photo-3.jpg","Popular"),
                    new Movie("Jiu jitsu","Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ", DateTime.Now ,"Action, Fantasy, Science Fiction", 142, "/images/photo-4.jpg","Popular"),
                    new Movie("Jiu jitsu","Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ", DateTime.Now ,"Action, Fantasy, Science Fiction", 142, "/images/photo-5.jpg","Popular"),
                    new Movie("Jiu jitsu","Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ", DateTime.Now ,"Action, Fantasy, Science Fiction", 142, "/images/photo-6.jpg","Popular"),

            };
>>>>>>> master
        }
    }
}
