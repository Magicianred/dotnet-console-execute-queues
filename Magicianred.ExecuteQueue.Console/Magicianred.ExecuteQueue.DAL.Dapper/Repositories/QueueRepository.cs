using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using Magicianred.ExecuteQueue.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Runner.DAL.Dapper.Repositories
{
    public class QueueRepository : IQueueRepository
    {
        public IEnumerable<IQueue> GetAll()
        {
            throw new System.NotImplementedException();
        }
        public IQueue GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
