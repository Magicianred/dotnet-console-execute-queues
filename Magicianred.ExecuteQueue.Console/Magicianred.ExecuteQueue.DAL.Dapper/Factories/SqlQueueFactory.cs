using Magicianred.ExecuteQueue.DAL.Dapper.Models;
using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;
using System.Linq;

using QueueModel = Magicianred.ExecuteQueue.Domain.Models.Queue;

namespace Magicianred.ExecuteQueue.DAL.Dapper.Factories
{
    /// <summary>
    /// Convert sql entity to domain
    /// </summary>
    public static class SqlQueueFactory
    {
        /// <summary>
        /// Covert 
        /// </summary>
        /// <param name="sqlEntity"></param>
        /// <returns></returns>
        public static IQueue ToModelDomain(this SqlQueue sqlEntity)
        {
            IQueue model = null;
            if (sqlEntity != null)
            {
                model = new QueueModel
                {
                    Id = sqlEntity.Id,
                    ActionId = sqlEntity.ActionId,
                    ExecuteDate = sqlEntity.ExecuteDate,
                    LogId = sqlEntity.LogId,
                    ParentId = sqlEntity.ParentId,
                    Payload = sqlEntity.Payload,
                    StatusId = sqlEntity.StatusId,
                    TypeId = sqlEntity.TypeId
                };
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlEntities"></param>
        /// <returns></returns>
        public static List<IQueue> ToModelsDomain(this List<SqlQueue> sqlEntities)
        {
            List<IQueue> models = new();
            if (sqlEntities != null && sqlEntities.Any())
            {
                models = new List<IQueue>();
                sqlEntities.ForEach(item =>
                {
                    models.Add(item.ToModelDomain());
                });
            }
            return models;
        }
    }
}
