using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class FavouriteMovie
    {
        [Key, Column(Order = 0)]
        public int FavouriteId { get; set; }
        [Key, Column(Order = 1)]
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Favourite Favourite { get; set; }

        public FavouriteMovie(int favouriteId, int movieId)
        {
            FavouriteId = favouriteId;
            MovieId = movieId;
        }
    }
}
