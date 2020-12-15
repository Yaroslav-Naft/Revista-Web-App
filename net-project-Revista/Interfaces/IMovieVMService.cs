using Microsoft.AspNetCore.Mvc.Rendering;
using net_project_Revista.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Interfaces
{
    public interface IMovieVMService
    {
        MovieIndexVM GetMoviesVM(int pageIndex, int itemsPerPage, int? categoryId);
        IEnumerable<SelectListItem> GetCategories();
    }
}
