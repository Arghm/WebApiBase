using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WebApi.Common
{
    public class ConnectionFactory
    {
        private readonly DataBaseConfig _dbconfig;
        public ConnectionFactory(DataBaseConfig dbconfig)
        {
            _dbconfig = dbconfig;
        }

        public SqlConnection GetDbConnection()
        {
            return new SqlConnection(_dbconfig.ConnectionString);
        }
    }
}
