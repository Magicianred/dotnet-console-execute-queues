namespace Magicianred.ExecuteQueue.DAL.Dapper.Models
{
    public class SqlQueueLogItem
    {
        public long Id { get; set; }
        public long LogId { get; set; }
        public int TypeId { get; set; }
        public string Message { get; set; }
    }
}
