using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.ViewModels
{
    public class MovieIndexVM
    {
        public List<MovieVM> Movies { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public int? CategoriesFilterApplied { get; set; }
    }
}
