using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.ViewModels
{
    public class PaginationInfoVM
    {
        public int TotalItems{ get; set; }
        public int ItemsPerPage { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public string Previuos { get; set; }
        public string Next { get; set; }
    }
}
