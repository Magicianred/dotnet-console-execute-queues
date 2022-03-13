using Magicianred.ExecuteQueue.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Repositories
{
    public interface IQueueTargetRepository
    {
        public IEnumerable<IQueueTargetService> GetAllByQueueId(long queueId);
    }
}
