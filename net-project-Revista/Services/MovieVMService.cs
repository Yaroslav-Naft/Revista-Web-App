using Microsoft.AspNetCore.Mvc.Rendering;
using net_project_Revista.Interfaces;
using net_project_Revista.Models;
using net_project_Revista.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Services
{
    public class MovieVMService : IMovieVMService
    {
        private readonly IBaseRepository<Movie> _movieRepo;
        private readonly IBaseRepository<MovieCategory> _categoryRepo;

        public MovieVMService(IBaseRepository<Movie> movieRepo, IBaseRepository<MovieCategory> categoryRepo)
        {
            _movieRepo = movieRepo;
            _categoryRepo = categoryRepo;
        }

        public MovieIndexVM GetMoviesVM(int pageIndex, int itemsPerPage, int? categoryId)
        {
            IQueryable<Movie> movies = _movieRepo.GetAll();
          

            if(categoryId != null)
            {
                movies = movies.Where(m => m.CategoryId == categoryId); 
           
            }

            int totalItems = movies.Count();
            movies = movies.Skip(pageIndex * itemsPerPage).Take(itemsPerPage);

            var vm = new MovieIndexVM()
            {
                Movies = movies.Select(m => new MovieVM
                {
                    Id = m.Id,
                    Title = m.Title,
                    Overview = m.Overview,
                    ReleaseDate = m.ReleaseDate.ToString("MMMM dd, yyyy"),
                    PosterPath = "https://image.tmdb.org/t/p/w500" + m.PosterPath
                }).ToList(),
                Categories = GetCategories().ToList(),
                PaginationInfo = new PaginationInfoVM()
                {
                    PageIndex = pageIndex,
                    ItemsPerPage = movies.Count(),
                    TotalItems = totalItems,
                    TotalPages = int.Parse(Math.Ceiling((decimal)totalItems /itemsPerPage).ToString())
                }
            };

            vm.PaginationInfo.Previuos = vm.PaginationInfo.PageIndex == 0 ? "is-disabled" : "";
            vm.PaginationInfo.Next = vm.PaginationInfo.PageIndex == vm.PaginationInfo.TotalPages - 1? "is-disabled" : "";
            return vm;
        }

        public IEnumerable<SelectListItem> GetCategories()
        {
            var categories = _categoryRepo.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Category
            }).OrderBy(c => c.Text).ToList();

            var allItem = new SelectListItem() { Value = null, Text = "All", Selected = true };
            categories.Insert(0, allItem);

            return categories;
        }
    }
}
