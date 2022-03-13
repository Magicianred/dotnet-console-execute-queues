namespace Magicianred.ExecuteQueue.Domain.Interfaces.Handlers
{
    public interface IQueueHandler
    {
        public bool InitQueueProcessor();
        public bool RunQueueProcessor();
    }
}
