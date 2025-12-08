using System.ComponentModel.DataAnnotations;

namespace sessionTpDIP.ViewModels
{
    public class AuthVm
    {
        [Required(ErrorMessage ="The username is required")]
        public string  Username{ get; set; }
        [Required(ErrorMessage = "The password is required")]
        [DataType(DataType.Password)]
        public string  Password { get; set; }
    }
}
