using System;
using System.Collections.Generic;

#nullable disable

namespace Magicianred.ExecuteQueue.Log.DAL.Ef.MySql.EfModels
{
    public partial class QueueLog
    {
        public long Id { get; set; }
        public long QueueId { get; set; }
    }
}
