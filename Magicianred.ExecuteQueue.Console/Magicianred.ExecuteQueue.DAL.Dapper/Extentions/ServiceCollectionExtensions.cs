using Magicianred.ExecuteQueue.Runner.DAL.Dapper.Repositories;
using Magicianred.ExecuteQueue.Runner.DAL.Dapper.Repositories.Base;
using Magicianred.ExecuteQueue.Domain.Interfaces.Repositories;
using Magicianred.ExecuteQueue.Domain.Interfaces.Repositories.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Magicianred.ExecuteQueue.Runner.DAL.Dapper.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDalDapper(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseConnectionFactory, DatabaseConnectionFactory>();

            services.AddScoped<IQueueRepository, QueueRepository>();
            services.AddScoped<IQueueTypeRepository, QueueTypeRepository>();
            services.AddScoped<IQueueActionRepository, QueueActionRepository>();
            services.AddScoped<IQueueStatusRepository, QueueStatusRepository>();
            services.AddScoped<IQueueLogRepository, QueueLogRepository>();
            services.AddScoped<IQueueLogTypeRepository, QueueLogTypeRepository>();
            services.AddScoped<IQueueLogItemRepository, QueueLogItemRepository>();
            services.AddScoped<IQueueTargetRepository, QueueTargetRepository>();
        }
    }
}