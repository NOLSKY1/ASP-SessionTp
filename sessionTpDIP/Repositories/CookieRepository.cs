namespace sessionTpDIP.Repositories
{
    public class CookieRepository
    {
        public string Get(HttpContext context , string key)
        {
            return context.Request.Cookies[key] ?? "";
        }
        public void Set(HttpContext context, string key , string value)
        {
            context.Response.Cookies.Append(key, value);
        }

    }
}
