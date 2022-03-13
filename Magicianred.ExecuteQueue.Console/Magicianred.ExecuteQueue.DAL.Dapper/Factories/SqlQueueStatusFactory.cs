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
    public static class SqlQueueStatusFactory
    {
        /// <summary>
        /// Covert 
        /// </summary>
        /// <param name="sqlEntity"></param>
        /// <returns></returns>
        public static IQueueStatus ToModelDomain(this SqlQueueStatus sqlEntity)
        {
            IQueueStatus model = null;
            if (sqlEntity != null)
            {
                model = new QueueStatus
                {
                    Id = sqlEntity.Id,
                    Name = sqlEntity.Name,
                    Description = sqlEntity.Description
                };
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlEntities"></param>
        /// <returns></returns>
        public static List<IQueueStatus> ToModelsDomain(this List<SqlQueueStatus> sqlEntities)
        {
            List<IQueueStatus> models = new();
            if (sqlEntities != null && sqlEntities.Any())
            {
                models = new List<IQueueStatus>();
                sqlEntities.ForEach(item =>
                {
                    models.Add(item.ToModelDomain());
                });
            }
            return models;
        }
    }
}
