using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Repositories
{
    public interface IQueueActionRepository
    {
        public IEnumerable<IQueueAction> GetAll();
    }
}
