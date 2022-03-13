using Magicianred.ExecuteQueue.Domain.Interfaces.Models;

namespace Magicianred.ExecuteQueue.Domain.Models
{
    public class QueueStatus : IQueueStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
