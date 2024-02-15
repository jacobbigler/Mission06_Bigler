using Microsoft.AspNetCore.Mvc;
using Mission06_Bigler.Models;
using SQLitePCL;
using System.Diagnostics;

namespace Mission06_Bigler.Controllers
{
    public class HomeController : Controller
    {

        private ContributeContext _context;

        public HomeController(ContributeContext temp) //Constructor 
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

        [HttpGet]
        public IActionResult Contribute()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contribute(Contribution response)
        {
            _context.Contributions.Add(response);
            _context.SaveChanges();

            return View("Success", response);
        }

    }
}
