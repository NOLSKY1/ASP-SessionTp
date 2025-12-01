using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace sessionTpDIP.Filters
{
    public class AuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            if (context.HttpContext.Session.GetString("username") == null)
            {
                //context.HttpContext.Response.Redirect("/auth/login");
                context.Result = new RedirectResult("/auth/login");
            }
        }
    }
}
