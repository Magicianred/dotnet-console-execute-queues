using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Repositories
{
    public interface IQueueLogTypeRepository
    {
        public IEnumerable<IQueueLogType> GetAll();
    }
}
