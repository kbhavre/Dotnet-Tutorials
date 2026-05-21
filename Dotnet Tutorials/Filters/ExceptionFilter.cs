using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Dotnet_Tutorials.Filters
{
    public class ExceptionFilter : IExceptionFilter 
    {
        public void OnException(ExceptionContext context)
        {
            Console.WriteLine("Exception caught inside error");
            Console.WriteLine(context.Exception.Message);

            context.Result = new ViewResult
            {
                ViewName = "Error"
            };

            context.ExceptionHandled = true;
        }  
    }
}
