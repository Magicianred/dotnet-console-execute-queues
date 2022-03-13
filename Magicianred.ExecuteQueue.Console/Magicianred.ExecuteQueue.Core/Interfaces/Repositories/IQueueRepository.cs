using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Repositories
{
    public interface IQueueRepository
    {
        public IEnumerable<IQueue> GetAll();
        public IQueue GetById(int id);
    }
}
