using Magicianred.ExecuteQueue.BL.Handlers;
using Magicianred.ExecuteQueue.BL.Services;
using Magicianred.ExecuteQueue.Domain.Interfaces.Handlers;
using Magicianred.ExecuteQueue.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Magicianred.ExecuteQueue.BL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBL(this IServiceCollection services)
        {
            services.AddScoped<IQueueHandler, QueueHandler>();

            services.AddScoped<IQueueService, QueueService>();
            services.AddScoped<IQueueTypeService, QueueTypeService>();
            services.AddScoped<IQueueActionService, QueueActionService>();
            services.AddScoped<IQueueStatusService, QueueStatusService>();
            services.AddScoped<IQueueLogService, QueueLogService>();
            services.AddScoped<IQueueLogTypeService, QueueLogTypeService>();
            services.AddScoped<IQueueLogItemService, QueueLogItemService>();
            services.AddScoped<IQueueTargetService, QueueTargetService>();
        }
    }
}
