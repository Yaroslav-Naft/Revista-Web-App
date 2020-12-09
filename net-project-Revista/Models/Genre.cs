using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class Genre : BaseEntity
    {
        public int GenreId { get; set; }
        public string Name{ get; set; }

        // navigation properties
        public virtual ICollection<MovieGenre> MovieGenres { get; set; }

        public Genre(int genreId, string name)
        {
            GenreId = genreId;
            Name = name;
        }
    }

}
