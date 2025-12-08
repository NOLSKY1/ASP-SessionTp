using Microsoft.AspNetCore.Mvc;
using sessionTpDIP.Filters;
using sessionTpDIP.Services;

namespace sessionTpDIP.Controllers
{
    public class ThemeController : Controller
    {
        private readonly IThemeService _IthemeService;
        public ThemeController(IThemeService themeService) {
            _IthemeService = themeService;
        }
        [HttpPost]
        public IActionResult Switch()
        {
            _IthemeService.manageTheme(HttpContext);
            return RedirectToAction("Index" , "Home");
        }
    }
}
