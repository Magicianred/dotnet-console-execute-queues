namespace Magicianred.ExecuteQueue.Domain.Interfaces.Models
{
    public interface IQueueAction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
