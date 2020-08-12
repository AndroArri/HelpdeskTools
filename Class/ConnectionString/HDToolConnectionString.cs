using System;
using System.Data.SqlClient;

namespace helpDeskTools.Class.ConnectionString
{
    public class HdToolConnectionString
    {
        private SqlConnectionStringBuilder _connectionString;

        public SqlConnectionStringBuilder connectionStringBuilder
        {
            get => _connectionString ?? (_connectionString = new SqlConnectionStringBuilder(Properties.Settings.Default.HDToolConnectionString));
            internal set
            {
                _connectionString = value;
                Properties.Settings.Default.HDToolConnectionString = _connectionString.ConnectionString;
                Properties.Settings.Default.Save();
            }
        }

        public string ConnectionString
        {
            get => connectionStringBuilder.ConnectionString;
            set => connectionStringBuilder = new SqlConnectionStringBuilder(value);
        }

        public HdToolConnectionString()
        {
            SetConnectionString("CVS148", "HelpDeskTools", "sa", "123");
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
                this.connectionStringBuilder = connectionStringBuilder;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
