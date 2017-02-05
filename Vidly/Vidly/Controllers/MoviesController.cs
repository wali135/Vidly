using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {

            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Random(int? id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            

            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id=1,Name="Sherk" },
                new Movie {Id=2, Name="Wall-E" }

            };
        }
    }
}