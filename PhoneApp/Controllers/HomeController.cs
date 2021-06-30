using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using PhoneApp.Models;
using Microsoft.Extensions.Logging;

namespace PhoneApp.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(MobileContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var a = db.Phones.ToList();
            return View(a);
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
