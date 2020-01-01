using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Woz.TEMPer;

namespace Woz.TEMPerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TEMPerSensors.Create(null);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) 
            => Host
                .CreateDefaultBuilder(args)
                .UseWindowsService()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
