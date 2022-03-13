using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Services
{
    public interface IQueueActionService
    {
        public IEnumerable<IQueueAction> GetAll();
    }
}
