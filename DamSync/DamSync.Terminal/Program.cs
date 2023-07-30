using DamSync.Terminal.Interfeces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace DamSync.Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                services.GetRequiredService<App>().Run(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            IHostBuilder CreateHostBuilder(string[] strings)
            {
                return Host.CreateDefaultBuilder()
                    .ConfigureServices((_, services) =>
                    {
                        services.AddSingleton<ISyncService, SyncService>();
                        services.AddSingleton<App>();
                    });
    //                .UseSerilog((context, services, configuration) => configuration
    //.ReadFrom.Configuration(context.Configuration)
    //.ReadFrom.Services(services)
    //.Enrich.FromLogContext()
    //.WriteTo.File($"report-{DateTimeOffset.UtcNow.ToString("yyyy-MM-dd-HH-mm-ss")}.txt", restrictedToMinimumLevel: LogEventLevel.Warning));
            }


        }
    }
}