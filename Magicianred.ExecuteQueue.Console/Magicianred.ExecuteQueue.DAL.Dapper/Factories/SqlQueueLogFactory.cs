using Magicianred.ExecuteQueue.DAL.Dapper.Models;
using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using Magicianred.ExecuteQueue.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Magicianred.ExecuteQueue.DAL.Dapper.Factories
{
    /// <summary>
    /// Convert sql entity to domain
    /// </summary>
    public static class SqlQueueLogFactory
    {
        /// <summary>
        /// Covert 
        /// </summary>
        /// <param name="sqlEntity"></param>
        /// <returns></returns>
        public static IQueueLog ToModelDomain(this SqlQueueLog sqlEntity)
        {
            IQueueLog model = null;
            if (sqlEntity != null)
            {
                model = new QueueLog
                {
                    Id = sqlEntity.Id,
                };
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlEntities"></param>
        /// <returns></returns>
        public static List<IQueueLog> ToModelsDomain(this List<SqlQueueLog> sqlEntities)
        {
            List<IQueueLog> models = new();
            if (sqlEntities != null && sqlEntities.Any())
            {
                models = new List<IQueueLog>();
                sqlEntities.ForEach(item =>
                {
                    models.Add(item.ToModelDomain());
                });
            }
            return models;
        }
    }
}
