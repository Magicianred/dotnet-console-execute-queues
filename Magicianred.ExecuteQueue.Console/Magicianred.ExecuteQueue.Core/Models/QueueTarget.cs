using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System;

namespace Magicianred.ExecuteQueue.Domain.Models
{
    public class QueueTarget : IQueueTarget
    {
        public long Id { get; set; }
        public long QueueId { get; set; }
        public IQueue Queue { get; set; }
        public long EntityId { get; set; }
        public int EntityTypeId { get; set; }
        public int StatusId { get; set; }
        public IQueueStatus Status { get; set; }
        public DateTime ExecuteDate { get; set; }
    }
}
