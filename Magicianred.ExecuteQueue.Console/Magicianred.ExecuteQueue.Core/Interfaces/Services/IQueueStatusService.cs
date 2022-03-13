using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Services
{
    public interface IQueueStatusService
    {
        public IEnumerable<IQueueStatus> GetAll();
    }
}
