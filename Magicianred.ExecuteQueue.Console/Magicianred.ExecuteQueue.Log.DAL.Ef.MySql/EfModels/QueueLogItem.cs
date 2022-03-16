using System;
using System.Collections.Generic;

#nullable disable

namespace Magicianred.ExecuteQueue.Log.DAL.Ef.MySql.EfModels
{
    public partial class QueueLogItem
    {
        public long Id { get; set; }
        public long LogId { get; set; }
        public string Message { get; set; }
        public int LogTypeId { get; set; }

        public virtual QueueLogType LogType { get; set; }
    }
}
