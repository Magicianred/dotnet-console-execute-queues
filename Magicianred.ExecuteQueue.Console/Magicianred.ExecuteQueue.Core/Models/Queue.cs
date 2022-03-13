using Magicianred.ExecuteQueue.Domain.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace Magicianred.ExecuteQueue.Domain.Models
{
    public class Queue : IQueue
    {
        public long Id { get; set; }
        public DateTime ExecuteDate { get; set; }
        public long ParentId { get; set; }
        public int TypeId { get; set; }
        public IQueueType Type { get; set; }
        public int ActionId { get; set; }
        public IQueueAction Action { get; set; }
        public int StatusId { get; set; }
        public IQueueStatus Status { get; set; }
        public string Payload { get; set; }
        public long LogId { get; set; }
        public IQueueLog Log { get; set; }
        public List<IQueueTarget> Targets { get; set; }
    }
}
