using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using Magicianred.ExecuteQueue.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.BL.Services
{
    public class QueueTargetService : IQueueTargetService
    {
        public IEnumerable<IQueueTarget> GetAllByQueueId(long queueId) {

            throw new System.NotImplementedException();
        }
    }
}
