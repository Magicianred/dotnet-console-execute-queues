using Magicianred.ExecuteQueue.Runner.DAL.Dapper.Models;
using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using Magicianred.ExecuteQueue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Magicianred.ExecuteQueue.Runner.DAL.Dapper.Factories
{
    /// <summary>
    /// Convert sql entity to domain
    /// </summary>
    public static class SqlQueueTargetFactory
    {
        /// <summary>
        /// Covert 
        /// </summary>
        /// <param name="sqlEntity"></param>
        /// <returns></returns>
        public static IQueueTarget ToModelDomain(this SqlQueueTarget sqlEntity)
        {
            IQueueTarget model = null;
            if (sqlEntity != null)
            {
                model = new QueueTarget
                {
                    Id = sqlEntity.Id,
                    EntityId = sqlEntity.EntityId,
                    EntityTypeId = sqlEntity.EntityTypeId,
                    ExecuteDate = sqlEntity.ExecuteDate,
                    QueueId = sqlEntity.QueueId,
                    StatusId = sqlEntity.StatusId
                };
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlEntities"></param>
        /// <returns></returns>
        public static List<IQueueTarget> ToModelsDomain(this List<SqlQueueTarget> sqlEntities)
        {
            List<IQueueTarget> models = new();
            if (sqlEntities != null && sqlEntities.Any())
            {
                models = new List<IQueueTarget>();
                sqlEntities.ForEach(item =>
                {
                    models.Add(item.ToModelDomain());
                });
            }
            return models;
        }
    }
}
