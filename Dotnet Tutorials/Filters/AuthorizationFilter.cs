using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Dotnet_Tutorials.Filters
{
    public class AuthorizationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var isLoggedIn = context.HttpContext.Session.GetString("UserName");
            if(string.IsNullOrEmpty(isLoggedIn))
            {
                context.Result = new RedirectToActionResult("Login", "Account", null);  
            }
            base.OnActionExecuting(context);
        }


    }
}
