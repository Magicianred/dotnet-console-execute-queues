using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using Magicianred.ExecuteQueue.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Runner.DAL.Dapper.Repositories
{
    public class QueueActionRepository : IQueueActionRepository
    {
        public IEnumerable<IQueueAction> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
