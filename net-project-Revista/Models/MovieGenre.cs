using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class MovieGenre : BaseEntity
    {
        [Key, Column(Order = 0)]
        public int MovieId { get; set; }
        [Key, Column(Order = 1)]
        public int GenreId { get; set; }
        

        // navigation properties
        public virtual Genre Genre { get; set; }
        public virtual Movie Movie { get; set; }

        public MovieGenre(int genreId, int movieId)
        {
            GenreId = genreId;
            MovieId = movieId;
        }
    }
}
