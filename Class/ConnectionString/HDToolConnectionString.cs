using System;
using System.Data.SqlClient;

namespace helpDeskTools.Class.ConnectionString
{
    public class HdToolConnectionString
    {
        public static SqlConnectionStringBuilder ConnectionStringBuilder =>
            new SqlConnectionStringBuilder()
            {
                UserID = "sa",
                Password = "123",
                InitialCatalog = "HelpDeskTools",
                DataSource = "CVS148"
            };

        public static readonly string ConnectionString = ConnectionStringBuilder.ConnectionString;
    }
}
