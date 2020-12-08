using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using net_project_Revista.Data;
using net_project_Revista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MovieDbContext _db;
       
        public IndexModel(MovieDbContext db)
        {
            _db = db;
        }

        public ICollection<Movie> Movies { get; private set; }

        public void OnGet()
        {
        }
    }
}
