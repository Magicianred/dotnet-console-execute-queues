using System;

namespace Magicianred.ExecuteQueue.DAL.Dapper.Models
{
    public class SqlQueue
    {
        public long Id { get; set; }
        public DateTime ExecuteDate { get; set; }
        public long ParentId { get; set; }
        public int TypeId { get; set; }
        public int ActionId { get; set; }
        public int StatusId { get; set; }
        public string Payload { get; set; }
        public long LogId { get; set; }
    }
}
