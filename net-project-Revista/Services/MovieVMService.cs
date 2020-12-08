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

        public MovieIndexVM GetMoviesVM(int? categoryId)
        {
            IQueryable<Movie> movies = _movieRepo.GetAll();

            if(categoryId != null)
            {
                movies = movies.Where(m => m.CategoryId == categoryId);
            }

            var vm = new MovieIndexVM()
            {
                Movies = movies.Select(m => new MovieVM
                {
                    Id = m.Id,
                    Title = m.Title,
                    Overview = m.Overview,
                    PosterPath = m.PosterPath
                }).ToList(),
                Categories = GetCategories().ToList()
            };

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

            return categories;
        }
    }
}
