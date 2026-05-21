using Dotnet_Tutorials.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Dotnet_Tutorials.Filters
{
    public class CustomValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.ActionArguments.TryGetValue("model", out var value) && value is UserFormModel model)
            {
                if (string.IsNullOrWhiteSpace(model.Name))
                {
                    context.ModelState.AddModelError(nameof(model.Name), "Name is required");
                }
                if (string.IsNullOrWhiteSpace(model.Email))
                {
                    context.ModelState.AddModelError(nameof(model.Email), "Email is required");
                }
                if (model.Age < 18)
                {
                    context.ModelState.AddModelError(nameof(model.Age), "Age must be 18 or above");
                }

                if (!context.ModelState.IsValid)
                {
                    context.Result = new ViewResult
                    {
                        ViewName = "Index",
                        ViewData = new ViewDataDictionary(
                            new EmptyModelMetadataProvider(),
                            context.ModelState)
                        {
                            Model = model
                        }
                    };
                }
            }
            base.OnActionExecuting(context);
        }
    }
}
