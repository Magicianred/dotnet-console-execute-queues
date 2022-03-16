using Magicianred.ExecuteQueue.Domain.Interfaces.Repositories;
using Magicianred.ExecuteQueue.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Runner.DAL.Dapper.Repositories
{
    public class QueueTargetRepository : IQueueTargetRepository
    {
        public IEnumerable<IQueueTargetService> GetAllByQueueId(long queueId)
        {
            throw new System.NotImplementedException();
        }
    }
}
