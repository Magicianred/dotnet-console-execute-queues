using Magicianred.ExecuteQueue.ConsoleApp.Extensions;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace Magicianred.ExecuteQueue.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseStartup<Startup>(); // our new method!
    }
}
