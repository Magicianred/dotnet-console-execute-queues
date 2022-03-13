using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Magicianred.ExecuteQueue.ConsoleApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureServices(IServiceCollection services)
        {
            // Configure your services here
        }
    }
}
