using sessionTpDIP.ViewModels;

namespace sessionTpDIP.Services
{
    public interface IAuthService
    {
        public bool login(AuthVm vm, HttpContext context);
    }
}
