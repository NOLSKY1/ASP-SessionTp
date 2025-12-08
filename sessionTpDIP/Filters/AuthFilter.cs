using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using sessionTpDIP.Services;

namespace sessionTpDIP.Filters
{
    public class AuthFilter : ActionFilterAttribute
    {
        private readonly IAuthService _IauthService;
        public AuthFilter(IAuthService IauthService)
        {
            this._IauthService = IauthService;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            if (_IauthService.getUser(context.HttpContext ,"username") == null)
            {
                //context.HttpContext.Response.Redirect("/auth/login");
                context.Result = new RedirectResult("/auth/login");
            }
        }
    }
}
