using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace sessionTpDIP.Controllers
{
    // it was just for the purpose of testing 
    public class AuthenticationController : Controller
    {
        //public override void OnActionExecuting(ActionExecutingContext context)
        //{
        //    base.OnActionExecuting(context);
        //    if (context.HttpContext.Session.GetString("username") == null)
        //    {
        //        //context.HttpContext.Response.Redirect("/auth/login");
        //        context.Result = new RedirectResult("/auth/login");
        //    }
        //}
    }
}
