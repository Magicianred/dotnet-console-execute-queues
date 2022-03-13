using System.Data;

namespace Magicianred.ExecuteQueue.Domain.Interfaces.Repositories.Base
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
