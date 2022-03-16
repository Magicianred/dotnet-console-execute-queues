using System;
using System.Collections.Generic;

#nullable disable

namespace Magicianred.ExecuteQueue.Runner.DAL.Ef.MySql.EfModels
{
    public partial class QueueTarget
    {
        public long Id { get; set; }
        public long QueueId { get; set; }
        public long EntityId { get; set; }
        public long? EntityTypeId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ExecuteDate { get; set; }

        public virtual Queue Queue { get; set; }
    }
}
