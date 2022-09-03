using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace microservicio.dotnet.test
{
    public class Startup
    {

        private IConfiguration _configuration;

        public void ConfigureHost(IHostBuilder hostBuilder)
        {

            _configuration = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();


            hostBuilder.ConfigureAppConfiguration(
                config =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
                    config.AddEnvironmentVariables();
                });
        } 

        public void ConfigureServices(IServiceCollection services)
        {
             
        }
    }
}
