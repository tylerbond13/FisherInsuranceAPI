using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FisherInsuranceAPI.Data;

namespace FisherInsuranceAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .AddEnvironmentVariables(prefix: "ASPNETCORE_")
                .Build();

            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            NewMethod(services);
            services.AddMvc();
        }

        private static void NewMethod(IServiceCollection services)
        {
            services.AddSingleton<IMemoryStore, MemoryStore>();
        }
    }
}
