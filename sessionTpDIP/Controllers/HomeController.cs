using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sessionTpDIP.Models;

namespace sessionTpDIP.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
