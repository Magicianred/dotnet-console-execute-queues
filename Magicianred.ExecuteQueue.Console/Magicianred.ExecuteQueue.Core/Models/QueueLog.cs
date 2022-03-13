using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Models
{
    public class QueueLog : IQueueLog
    {
        public long Id { get; set; }
        public List<IQueueLogItem> Items { get; set; }
    }
}
