using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Services
{
    public interface IQueueService
    {
        public IEnumerable<IQueue> GetAll();
        public IQueue GetById(int id);
    }
}
