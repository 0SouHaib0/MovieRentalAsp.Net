using MovieRental.Models;
using MovieRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            /* var movies = _context.Movies.Include(m=>m.Genre).ToList();
             return View(movies);*/
            return View();
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m=>m.Id==id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult FormMovie()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieGenreModel
            {
                Genres = genres
            };
            return View(viewModel);
        }
        public ActionResult EditMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieGenreModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };
           
            return View("FormMovie" , viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addOrEdit(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieGenreModel()
                {
                    Movie=movie,
                    Genres = _context.Genres.ToList()
                };

                return View("FormMovie", viewModel);
            }
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleasedDate = movie.ReleasedDate;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}