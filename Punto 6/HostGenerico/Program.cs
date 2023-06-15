using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HostGenerico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nuevoHost = CreateHostBuilder(args).Build();
            var logger = nuevoHost.Services.GetService<ILogger<Program>>();    
            logger.LogInformation("Work in Progress...");
            nuevoHost.Run();
            Console.ReadLine();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureLogging(logging =>
        {
            logging.ClearProviders();
            logging.AddConsole();
        });

    }
}