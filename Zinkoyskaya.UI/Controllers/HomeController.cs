using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Zinkoyskaya.UI.Models;

namespace Zinkoyskaya.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
