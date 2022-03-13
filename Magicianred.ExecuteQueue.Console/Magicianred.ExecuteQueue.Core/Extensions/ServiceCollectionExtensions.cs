using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using Magicianred.ExecuteQueue.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Magicianred.ExecuteQueue.Domain.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IQueue, Queue>();
            services.AddScoped<IQueueType, QueueType>();
            services.AddScoped<IQueueAction, QueueAction>();
            services.AddScoped<IQueueStatus, QueueStatus>();
            services.AddScoped<IQueueLog, QueueLog>();
            services.AddScoped<IQueueLogType, QueueLogType>();
            services.AddScoped<IQueueLogItem, QueueLogItem>();
            services.AddScoped<IQueueTarget, QueueTarget>();
        }
    }
}