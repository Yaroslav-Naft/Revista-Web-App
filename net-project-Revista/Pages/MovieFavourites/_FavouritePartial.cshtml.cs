using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using net_project_Revista.Data;
using net_project_Revista.Models;

namespace net_project_Revista.Pages.MovieFavourites
{
    public class _FavouritePartialModel : PageModel
    {
        private readonly net_project_Revista.Data.MovieDbContext _context;

        public string Posterpath { get; set; }
        public _FavouritePartialModel(net_project_Revista.Data.MovieDbContext context)
        {
            _context = context;
        }

        public IList<FavouriteMovie> FavouriteMovie { get;set; }

        public async Task OnGetAsync()
        {
            FavouriteMovie = await _context.FavouriteMovies
                .Include(f => f.Favourite)
                .Include(f => f.Movie).ToListAsync();
           

            Posterpath = "https://image.tmdb.org/t/p/w100" ;

        }
    }
}
