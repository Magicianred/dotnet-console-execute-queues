using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using Magicianred.ExecuteQueue.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.BL.Services
{
    public class QueueStatusService : IQueueStatusService
    {
        public IEnumerable<IQueueStatus> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
