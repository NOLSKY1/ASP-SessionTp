using sessionTpDIP.Models;
using sessionTpDIP.ViewModels;

namespace sessionTpDIP.Mappers
{
    public class UserMapper
    {
        public User authVmToUserModel(AuthVm vm)
        {
            return new User
            {
                Username = vm.Username,
                Password = vm.Password,
            };
        }
    }
}
