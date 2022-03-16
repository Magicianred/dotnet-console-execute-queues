using System;
using System.Collections.Generic;

#nullable disable

namespace Magicianred.ExecuteQueue.Runner.DAL.Ef.MySql.EfModels
{
    public partial class Queue
    {
        public Queue()
        {
            InverseParent = new HashSet<Queue>();
            QueueTargets = new HashSet<QueueTarget>();
        }

        public long Id { get; set; }
        public DateTime ExecuteDate { get; set; }
        public long? ParentId { get; set; }
        public int TypeId { get; set; }
        public int ActionId { get; set; }
        public int StatusId { get; set; }
        public string Payload { get; set; }

        public virtual QueueAction Action { get; set; }
        public virtual Queue Parent { get; set; }
        public virtual QueueStatus Status { get; set; }
        public virtual QueueType Type { get; set; }
        public virtual ICollection<Queue> InverseParent { get; set; }
        public virtual ICollection<QueueTarget> QueueTargets { get; set; }
    }
}
