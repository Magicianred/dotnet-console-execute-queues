using Magicianred.ExecuteQueue.Domain.Interfaces.Repositories.Base;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Magicianred.ExecuteQueue.DAL.Dapper.Repositories.Base
{
    public class DatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public DatabaseConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection()
        {
            var databaseType = _configuration.GetSection("DatabaseType").Value;
            if (!string.IsNullOrWhiteSpace(databaseType) && databaseType.ToLower().Trim() == "mysql")
            {
                return new MySqlConnection(_configuration.GetConnectionString("Queue_mysql"));
            }
            else if (!string.IsNullOrWhiteSpace(databaseType) && databaseType.ToLower().Trim() == "mssql")
            {
                return new SqlConnection(_configuration.GetConnectionString("Queue_mssql"));
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
