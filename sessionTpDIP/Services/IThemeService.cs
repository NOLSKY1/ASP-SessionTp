namespace sessionTpDIP.Services
{
    public interface IThemeService
    {
        public void manageTheme(HttpContext context );
        public string getTheme(HttpContext context);
    }
}
