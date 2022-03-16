using Magicianred.ExecuteQueue.Runner.DAL.Dapper.Models;
using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using Magicianred.ExecuteQueue.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Magicianred.ExecuteQueue.Runner.DAL.Dapper.Factories
{
    /// <summary>
    /// Convert sql entity to domain
    /// </summary>
    public static class SqlQueueLogItemFactory
    {
        /// <summary>
        /// Covert 
        /// </summary>
        /// <param name="sqlEntity"></param>
        /// <returns></returns>
        public static IQueueLogItem ToModelDomain(this SqlQueueLogItem sqlEntity)
        {
            IQueueLogItem model = null;
            if (sqlEntity != null)
            {
                model = new QueueLogItem
                {
                    Id = sqlEntity.Id,
                    TypeId = sqlEntity.TypeId,
                    LogId = sqlEntity.LogId,
                    Message = sqlEntity.Message
                };
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlEntities"></param>
        /// <returns></returns>
        public static List<IQueueLogItem> ToModelsDomain(this List<SqlQueueLogItem> sqlEntities)
        {
            List<IQueueLogItem> models = new();
            if (sqlEntities != null && sqlEntities.Any())
            {
                models = new List<IQueueLogItem>();
                sqlEntities.ForEach(item =>
                {
                    models.Add(item.ToModelDomain());
                });
            }
            return models;
        }
    }
}
