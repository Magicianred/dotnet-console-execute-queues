using Magicianred.ExecuteQueue.Domain.Interfaces.Models;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Repositories
{
    public interface IQueueLogItemRepository
    {
        public bool AddLog(IQueueLogItem item);
    }
}
