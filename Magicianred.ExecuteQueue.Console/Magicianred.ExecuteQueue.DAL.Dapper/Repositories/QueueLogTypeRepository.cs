using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using Magicianred.ExecuteQueue.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Runner.DAL.Dapper.Repositories
{
    public class QueueLogTypeRepository : IQueueLogTypeRepository
    {
        public IEnumerable<IQueueLogType> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
