namespace Dotnet_Tutorials.Middlewares
{
    public class IpAddressMiddleware
    {
        private readonly RequestDelegate _next;

        public IpAddressMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var ipAddress = context.Connection.RemoteIpAddress;
            Console.WriteLine($"User IP Address : {ipAddress}");
            await _next(context);
        }
    }
}
