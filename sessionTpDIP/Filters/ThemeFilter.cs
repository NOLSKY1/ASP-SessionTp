using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using sessionTpDIP.Services;

namespace sessionTpDIP.Filters
{
    public class ThemeFilter : ActionFilterAttribute
    {
        private readonly IThemeService _themeService; 
        public ThemeFilter(IThemeService themeService) {
            this._themeService = themeService;    
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            string theme = _themeService.getTheme(context.HttpContext);
            if (context.Controller is Controller controller)
            {
                controller.TempData["Theme"] = theme;
            }
        }
          

    }
}
