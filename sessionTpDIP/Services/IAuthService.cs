using sessionTpDIP.ViewModels;

namespace sessionTpDIP.Services
{
    public interface IAuthService
    {
        public bool login(AuthVm vm, HttpContext context);
        public string getUser(HttpContext context, string key);
        public void logout(HttpContext context);
    }
}
