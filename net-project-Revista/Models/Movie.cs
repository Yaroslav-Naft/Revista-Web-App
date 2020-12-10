using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class Movie : BaseEntity
    {
        public string Overview { get; private set; }
        public string PosterPath { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; private set; }
        public int MovieId { get; private set; }        
        public int CategoryId { get; private set; }

        // navigation properties
        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
        public virtual MovieCategory MovieCategory { get; set; }
        public virtual ICollection<FavouriteMovie> FavouriteMovies { get; set; }

        public Movie(string title,
                     int movieId,
                     string overview,
                     DateTime releaseDate,
                     string posterPath,
                     int categoryId)
        {
            MovieId = movieId;
            Overview = overview;
            PosterPath = posterPath;
            ReleaseDate = releaseDate;
            Title = title;                  
            CategoryId = categoryId;
        }
    }
}
