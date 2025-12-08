using sessionTpDIP.Mappers;
using sessionTpDIP.Models;
using sessionTpDIP.Persisters;
using sessionTpDIP.ViewModels;
using System.Runtime.CompilerServices;

namespace sessionTpDIP.Services
{
    public class AuthService : IAuthService
    {
        private readonly SessionRepository _sessionRepository ;
        private readonly UserMapper _userMapper;
        public AuthService(SessionRepository sessionRepository , UserMapper userMapper) { 
            this._sessionRepository = sessionRepository ;
            this._userMapper = userMapper;
        }
        public bool login(AuthVm vm , HttpContext context)
        {

            if (vm.Username == "admin" && vm.Password == "admin")
            {
                User user = _userMapper.authVmToUserModel(vm);
                _sessionRepository.SetUsername("username", context, user);
                return true;
            }
            return false;
        }
        public string getUser(HttpContext context ,string key)
        {
           return _sessionRepository.GetUsername(context, key);
        }
    }
}
