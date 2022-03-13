using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Models
{
    public interface IQueueLog
    {
        public long Id { get; set; }
        public List<IQueueLogItem> Items { get; set; }
    }
}
