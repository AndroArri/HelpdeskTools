using System;
using System.Data.SqlClient;
using System.Runtime.Remoting;
using helpDeskTools.Class.Database;

namespace helpDeskTools.Class.ConnectionString
{
    public class ArxConnectionString
    {
        private SqlConnectionStringBuilder _connectionString;
        private HDToolDB hdToolDb = new HDToolDB();

        public SqlConnectionStringBuilder ConnectionStringBuilder
        {
            get =>
                _connectionString ??
                (_connectionString = new SqlConnectionStringBuilder(hdToolDb.LoadArxConnectionString()));
            set => _connectionString = value;
        }

        public string ConnectionString
        {
            get
            {
                if (_connectionString is null)
                {
                    _connectionString = new SqlConnectionStringBuilder(hdToolDb.LoadArxConnectionString());
                }

                return _connectionString.ConnectionString;
            }
            set => _connectionString = new SqlConnectionStringBuilder(value);
        }


        public bool SetConnectionString(string addressDb, string database, string username, string pwd)
        {
            try
            {
                SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder()
                {
                    UserID = username,
                    Password = pwd,
                    InitialCatalog = database,
                    DataSource = addressDb
                };
                this.ConnectionStringBuilder = connectionStringBuilder;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



    }
}
