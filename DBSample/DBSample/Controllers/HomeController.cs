using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DBSample.Models;
using Microsoft.EntityFrameworkCore;

namespace DBSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SampleContext _context;

        public HomeController(ILogger<HomeController> logger, SampleContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.Include(u => u.Company).ToList();
            var companies = _context.Companies.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
