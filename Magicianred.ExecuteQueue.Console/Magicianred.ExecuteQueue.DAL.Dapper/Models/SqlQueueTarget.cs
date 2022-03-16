using System;

namespace Magicianred.ExecuteQueue.Runner.DAL.Dapper.Models
{
    public class SqlQueueTarget
    {
        public long Id { get; set; }
        public long QueueId { get; set; }
        public long EntityId { get; set; }
        public int EntityTypeId { get; set; }
        public int StatusId { get; set; }
        public DateTime ExecuteDate { get; set; }
    }
}
