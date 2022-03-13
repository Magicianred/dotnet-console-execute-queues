using Magicianred.ExecuteQueue.Domain.Interfaces.Models;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Services
{
    public interface IQueueLogItemService
    {
        public bool WriteLog(IQueueLogItem item);
    }
}
