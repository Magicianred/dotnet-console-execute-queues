using Magicianred.ExecuteQueue.Domain.Interfaces.Models;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Repositories
{
    public interface IQueueLogRepository
    {
        public bool AddLog(IQueueLog item);
    }
}
