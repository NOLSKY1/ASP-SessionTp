using Microsoft.AspNetCore.Mvc;
using sessionTpDIP.Filters;
using sessionTpDIP.Models;
using System.Diagnostics;

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
