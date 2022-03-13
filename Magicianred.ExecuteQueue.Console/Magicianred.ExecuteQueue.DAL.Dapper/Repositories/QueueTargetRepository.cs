using Magicianred.ExecuteQueue.Domain.Interfaces.Repositories;
using Magicianred.ExecuteQueue.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.BL.Repositories
{
    public class QueueTargetRepository : IQueueTargetRepository
    {
        public IEnumerable<IQueueTargetService> GetAllByQueueId(long queueId)
        {
            throw new System.NotImplementedException();
        }
    }
}
