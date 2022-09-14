using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "shrek!" };
            return View(movie);
        }
        public ActionResult Random1()
        {
            var movie = new Movie() { Name = "Jack reacher!" };
            return View(movie);
        }
    }
}