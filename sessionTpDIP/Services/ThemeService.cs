using sessionTpDIP.Repositories;

namespace sessionTpDIP.Services
{
    public class ThemeService : IThemeService
    {
        private readonly CookieRepository _cookieRepository;
        public ThemeService(CookieRepository cookieRepository)
        { 
            _cookieRepository = cookieRepository;
        }

        public void manageTheme(HttpContext context )
        {
            var currentTheme = _cookieRepository.Get(context,"theme");
            if (currentTheme == "" || currentTheme == "dark")
            {
                _cookieRepository.Set(context, "theme", "light");
            }
            else
            {
                _cookieRepository.Set(context, "theme", "dark");
            }
        }
        public string getTheme(HttpContext context)
        {

            return _cookieRepository.Get(context, "theme")  ;
        }
        }
}
