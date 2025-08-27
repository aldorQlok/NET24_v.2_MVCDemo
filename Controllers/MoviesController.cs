using Microsoft.AspNetCore.Mvc;
using MovieMVCDemo.Models;

namespace MovieMVCDemo.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            // Simulerar att jag gör API-anrop eller Hämtar data från en databas...
            var movies = new List<Movie>()
            {
                new Movie { Id = 1, Title = "Movie 1", Genre = "Genre 1", ReleaseYear = 2015},
                new Movie { Id = 2, Title = "Movie 2", Genre = "Genre 2", ReleaseYear = 2016},
                new Movie { Id = 3, Title = "Movie 3", Genre = "Genre 3", ReleaseYear = 2017},
            };

            return View(movies);
        }
    }
}
