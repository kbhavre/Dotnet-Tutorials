using Dotnet_Tutorials.Services.ActionFilters;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.Text.Json;

namespace Dotnet_Tutorials.Filters
{
    public class RequestLoggingFilter : IActionFilter
    {
        private readonly ILoggerService _loggerSrv;
        private Stopwatch? _timer;

        public RequestLoggingFilter(ILoggerService loggerService)
        {
            _loggerSrv = loggerService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _timer = Stopwatch.StartNew(); 
            var controller = context.RouteData.Values["controller"];
            var action = context.RouteData.Values["action"];
            var parameters = JsonSerializer.Serialize(context.ActionArguments);

            _loggerSrv.Log($"Controller : {controller}");
            _loggerSrv.Log($"Action : {action}");
            _loggerSrv.Log($"Parameters : {parameters}");
        }

        //811729

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _timer?.Stop();
            _loggerSrv.Log($"Execution Time : {_timer?.ElapsedMilliseconds} ms");

            if(context.Exception != null)
            {
                _loggerSrv.Log("EXCEPTION OCCURRED");
                _loggerSrv.Log(context.Exception.Message);
            }
        }

    }
}
