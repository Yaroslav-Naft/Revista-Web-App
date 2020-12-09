using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.ViewModels
{
    public class MovieVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Genre { get; set; }
        public string Category { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterPath { get; set; }
    }
}
