using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using helpDeskTools.Class.ConnectionString;

namespace helpDeskTools.Class.Database
{
    public abstract class IBaseDb
    {
        public string TableName { get; internal set; }
        public string DataType { get; internal set; }
        public int DataLength { get; internal set; }
        protected abstract DataTable ExecuteQuery(string scriptName, string connectionString);
    }
}
