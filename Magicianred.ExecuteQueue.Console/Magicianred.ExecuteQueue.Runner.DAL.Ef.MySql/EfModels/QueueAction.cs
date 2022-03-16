using System;
using System.Collections.Generic;

#nullable disable

namespace Magicianred.ExecuteQueue.Runner.DAL.Ef.MySql.EfModels
{
    public partial class QueueAction
    {
        public QueueAction()
        {
            Queues = new HashSet<Queue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Queue> Queues { get; set; }
    }
}
