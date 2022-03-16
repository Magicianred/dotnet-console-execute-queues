using System;
using System.Collections.Generic;

#nullable disable

namespace Magicianred.ExecuteQueue.Log.DAL.Ef.MySql.EfModels
{
    public partial class QueueLogType
    {
        public QueueLogType()
        {
            QueueLogItems = new HashSet<QueueLogItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<QueueLogItem> QueueLogItems { get; set; }
    }
}
