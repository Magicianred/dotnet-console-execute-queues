using Magicianred.ExecuteQueue.ConsoleApp.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace Magicianred.ExecuteQueue.ConsoleApp
{
    class Program
    {
        public static IConfiguration Configuration { get; private set; }

        static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // Connect to the database
            Configuration = ConfigurationHelper.GetConfiguration(args: args);
            var connectionString = Configuration.GetConnectionString("Main");
            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostBuilderContext, configuration) => {
                configuration.Sources.Clear();
                configuration
                    .AddEnvironmentVariables();

                IConfigurationRoot configurationRoot = configuration.Build();
                Configuration = configurationRoot;
            });
    }
}
