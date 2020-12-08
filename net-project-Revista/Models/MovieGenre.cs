using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class MovieGenre : BaseEntity
    {
        public int GenreId { get; set; }
        public string Genre { get; set; }

        // navigation properties
        public virtual ICollection<Movie> GenreMovies { get; set; }

        public MovieGenre(int genreId, string genre)
        {
            GenreId = genreId;
            Genre = genre;
        }
    }
}
