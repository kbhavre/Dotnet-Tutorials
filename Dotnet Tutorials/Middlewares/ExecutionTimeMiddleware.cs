using System.Diagnostics;

namespace Dotnet_Tutorials.Middlewares
{
    public class ExecutionTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public ExecutionTimeMiddleware(RequestDelegate next)
        {
            _next = next;         
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();
            await _next(context);
            stopwatch.Stop();

            Console.WriteLine($"Request Path : {context.Request.Path}");
            Console.WriteLine($"Request Time : {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
