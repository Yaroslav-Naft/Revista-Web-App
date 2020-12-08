using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class MovieGenre : BaseEntity
    {
        public string Genre { get; set; }

        // navigation properties
        public virtual ICollection<Movie> GenreMovies { get; set; }

        public MovieGenre(string genre)
        {
            Genre = genre;
        }
    }
}
