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
    public static class SqlQueueTypeFactory
    {
        /// <summary>
        /// Covert 
        /// </summary>
        /// <param name="sqlEntity"></param>
        /// <returns></returns>
        public static IQueueType ToModelDomain(this SqlQueueType sqlEntity)
        {
            IQueueType model = null;
            if (sqlEntity != null)
            {
                model = new QueueType
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
        public static List<IQueueType> ToModelsDomain(this List<SqlQueueType> sqlEntities)
        {
            List<IQueueType> models = new();
            if (sqlEntities != null && sqlEntities.Any())
            {
                models = new List<IQueueType>();
                sqlEntities.ForEach(item =>
                {
                    models.Add(item.ToModelDomain());
                });
            }
            return models;
        }
    }
}
