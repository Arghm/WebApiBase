using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WebApi.Common
{
    public class DataBaseConfig
    {
        private readonly IConfiguration _config;
        public DataBaseConfig(IConfiguration config)
        {
            _config = config;
            ConnectionString = _config.GetConnectionString("MainDb");
        }

        public string ConnectionString { get; }
    }
}
