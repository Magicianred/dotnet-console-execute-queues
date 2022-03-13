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
    public static class SqlQueueActionFactory
    {
        /// <summary>
        /// Covert 
        /// </summary>
        /// <param name="sqlEntity"></param>
        /// <returns></returns>
        public static IQueueAction ToModelDomain(this SqlQueueAction sqlEntity)
        {
            IQueueAction model = null;
            if (sqlEntity != null)
            {
                model = new QueueAction
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
        public static List<IQueueAction> ToModelsDomain(this List<SqlQueueAction> sqlEntities)
        {
            List<IQueueAction> models = new();
            if (sqlEntities != null && sqlEntities.Any())
            {
                models = new List<IQueueAction>();
                sqlEntities.ForEach(item =>
                {
                    models.Add(item.ToModelDomain());
                });
            }
            return models;
        }
    }
}
