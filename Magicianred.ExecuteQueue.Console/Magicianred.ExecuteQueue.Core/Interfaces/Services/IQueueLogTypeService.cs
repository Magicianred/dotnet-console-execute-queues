using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Services
{
    public interface IQueueLogTypeService
    {
        public IEnumerable<IQueueLogType> GetAll();
    }
}
