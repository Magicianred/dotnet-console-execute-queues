using Magicianred.ExecuteQueue.Domain.Interfaces.Models;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Services
{
    public interface IQueueLogService
    {
        public bool AddLog(IQueueLog item);
    }
}
