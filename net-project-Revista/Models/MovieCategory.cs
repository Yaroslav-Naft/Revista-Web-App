using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class MovieCategory : BaseEntity
    {
        public string Category { get; set; }

        // navigation properties
        public virtual ICollection<Movie> CategoryMovies { get; set; }

        //change later when we actually get categoryId
        public MovieCategory(string category)
        {
            Category = category;
        }
    }
}
