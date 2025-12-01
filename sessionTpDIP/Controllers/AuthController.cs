using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Logging;
using sessionTpDIP.Services;
using sessionTpDIP.ViewModels;

namespace sessionTpDIP.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            this._authService = authService;
        }
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(AuthVm vm)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            if (_authService.login(vm, HttpContext)){
                return RedirectToAction("index", "todo");
            }
            return View();
        }
    }
}
