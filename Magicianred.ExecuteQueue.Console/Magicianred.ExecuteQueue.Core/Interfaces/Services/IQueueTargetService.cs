using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Services
{
    public interface IQueueTargetService
    {
        public IEnumerable<IQueueTarget> GetAllByQueueId(long queueId);
    }
}
