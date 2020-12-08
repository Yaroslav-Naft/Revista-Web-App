using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class Movie : BaseEntity
    {
        public string Title { get; private set; }
        public string Overview { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string Genre { get; private set; }
        public int Runtime { get; private set; }
        public string PosterPath { get; private set; }
        public string Category { get; private set; }

        public Movie(string title,
                     string overview,
                     DateTime releaseDate,
                     string genre,
                     int runtime,
                     string posterPath,
                     string category)
        {
            Title = title;
            Overview = overview;
            ReleaseDate = releaseDate;
            Genre = genre;
            Runtime = runtime;
            PosterPath = posterPath;
            Category = category;
        }
    }
}
