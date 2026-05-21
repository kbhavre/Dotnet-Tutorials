namespace Dotnet_Tutorials.Services.ActionFilters
{
    public class LoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
