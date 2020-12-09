using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using net_project_Revista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

       
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public int Reps { get; set; } = 5;

        public List<Movie> Movies { get; set; } = new List<Movie>();

        public void OnGet()
        {
            //test with hard code movie
            Movies = new List<Movie>()
            {
                    //new Movie("Jiu jitsu","Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ", DateTime.Now ,"Action, Fantasy, Science Fiction", 142, "/images/photo-1.jpg","Popular"),
                    //new Movie("Uside Down Magic","Nory and her best friend Reina enter the Sage Academy for Magical Studies, where Nory’s unconventional powers land her in a class ", DateTime.Now ,"Family, Fantasy, TV Movie", 134, "/images/photo-2.jpg","Now Playing"),
                    //new Movie("Joker","During the 1980s, a failed stand-up comedian is driven insane and turns to a life of crime and chaos in Gotham City while becoming ", DateTime.Now ,"Crime, Thriller, Drama", 220, "/images/photo-3.jpg","Popular"),
                    //new Movie("Jiu jitsu","Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ", DateTime.Now ,"Action, Fantasy, Science Fiction", 142, "/images/photo-4.jpg","Popular"),
                    //new Movie("Jiu jitsu","Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ", DateTime.Now ,"Action, Fantasy, Science Fiction", 142, "/images/photo-5.jpg","Popular"),
                    //new Movie("Jiu jitsu","Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ", DateTime.Now ,"Action, Fantasy, Science Fiction", 142, "/images/photo-6.jpg","Popular"),

            };
        }
    }
}
