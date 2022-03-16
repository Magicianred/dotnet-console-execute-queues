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
    public static class SqlQueueLogTypeFactory
    {
        /// <summary>
        /// Covert 
        /// </summary>
        /// <param name="sqlEntity"></param>
        /// <returns></returns>
        public static IQueueLogType ToModelDomain(this SqlQueueLogType sqlEntity)
        {
            IQueueLogType model = null;
            if (sqlEntity != null)
            {
                model = new QueueLogType
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
        public static List<IQueueLogType> ToModelsDomain(this List<SqlQueueLogType> sqlEntities)
        {
            List<IQueueLogType> models = new();
            if (sqlEntities != null && sqlEntities.Any())
            {
                models = new List<IQueueLogType>();
                sqlEntities.ForEach(item =>
                {
                    models.Add(item.ToModelDomain());
                });
            }
            return models;
        }
    }
}
