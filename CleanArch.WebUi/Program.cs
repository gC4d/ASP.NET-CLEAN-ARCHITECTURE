using CleanArch.Infra.Data.Context;
using CleanArch.Infra.IoC;
using Microsoft.AspNetCore.Hosting;

namespace CleanArch.WebUi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}