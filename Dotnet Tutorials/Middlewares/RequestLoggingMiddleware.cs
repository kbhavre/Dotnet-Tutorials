namespace Dotnet_Tutorials.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("------------- Incoming Request -------------");
            Console.WriteLine($"Request Method : {context.Request.Method}");
            Console.WriteLine($"Request Path : {context.Request.Path}");
            Console.WriteLine($"Request Time : {DateTime.Now}");

            await _next(context);
            Console.WriteLine("------------- Request Completed -------------");
        }
    }
}
