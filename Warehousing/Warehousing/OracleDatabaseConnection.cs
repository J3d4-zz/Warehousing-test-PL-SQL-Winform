using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing
{
    class OracleDatabaseConnection
    {
        public OracleConnection getConnection()
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = ORCLCDB.localdomain)));" + "User Id=jeda;Password=f4kyouBlizzard;";
            return connection;
        }
    }
}