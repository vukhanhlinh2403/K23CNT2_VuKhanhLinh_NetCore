using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vkllesson06.Models;

namespace Vkllesson06.Controllers
{
    public class VklHomeController : Controller
    {
        private readonly ILogger<VklHomeController> _logger;

        public VklHomeController(ILogger<VklHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult VklIndex()
        {
            return View();
        }

        public IActionResult VklAbout()
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
