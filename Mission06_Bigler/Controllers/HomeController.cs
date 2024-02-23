using Microsoft.AspNetCore.Mvc;
using Mission06_Bigler.Models;
using SQLitePCL;
using System.Diagnostics;

namespace Mission06_Bigler.Controllers
{
    public class HomeController : Controller
    {

        private MoviesContext _context;

        public HomeController(MoviesContext temp) //Constructor 
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult MovieList() 
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }

    }
}
