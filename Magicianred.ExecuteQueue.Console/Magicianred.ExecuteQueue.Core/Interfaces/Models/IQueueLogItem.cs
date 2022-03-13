namespace Magicianred.ExecuteQueue.Domain.Interfaces.Models
{
    public interface IQueueLogItem
    {
        public long Id { get; set; }
        public long LogId { get; set; }
        public IQueueLog Log { get; set; }
        public int TypeId { get; set; }
        public IQueueLogType Type { get; set; }
        public string Message { get; set; }
    }
}
