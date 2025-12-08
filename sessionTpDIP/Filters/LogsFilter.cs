using Microsoft.AspNetCore.Mvc.Filters;
using sessionTpDIP.Services;

namespace sessionTpDIP.Filters
{
    public class LogsFilter : ActionFilterAttribute
    {   
        private readonly  IAuthService _IauthService;
        public LogsFilter(IAuthService IauthService) {
            this._IauthService = IauthService;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            string username = _IauthService.getUser(context.HttpContext, "username");
            DateTime currentDate = DateTime.Now;
            string controllerName = context.ActionDescriptor.RouteValues["controller"];
            string actionName = context.ActionDescriptor.RouteValues["action"];
            string method = context.HttpContext.Request.Method;
            using (StreamWriter writer = new StreamWriter(@"logs\log.txt" , append: true))
            {
                writer.WriteLine($"log at: {currentDate} ," +
                    $" Controller used: {controllerName} ," +
                    $" action done: {actionName} " +
                    $" Method type: {method}");
            }
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            string username = _IauthService.getUser(context.HttpContext, "username");
            DateTime currentDate = DateTime.Now;
            string controllerName = context.ActionDescriptor.RouteValues["controller"];
            string actionName = context.ActionDescriptor.RouteValues["action"];
            string method = context.HttpContext.Request.Method;
            using (StreamWriter writer = new StreamWriter(@"logs\log.txt", append: true))
            {
                writer.WriteLine($"Last log at: {currentDate} ," +
                    $" Controller used: {controllerName} ," +
                    $" action done: {actionName} " +
                    $" Method type: {method} ");
                writer.WriteLine("********************************");
            }
        }
    }
}
