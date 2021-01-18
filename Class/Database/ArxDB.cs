using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using helpDeskTools.Class.ConnectionString;
using helpDeskTools.Class.Database.HdToolDB;
using helpDeskTools.Class.Database.HdToolDB.PartialClass;
using Microsoft.SqlServer.Server;

namespace helpDeskTools.Class.Database
{
    public class ArxDb : BaseDb
    {

        private HelpDeskToolsDb _hdToolDB;
        private Table<DM_CONNECTION> dmConnection;
        private DM_CONNECTION arxConn;

        public const string TABLENAME = "TableName";
        public const string COLUMNNAME = "ColumnName";
        public const string DATATYPE = "DataType";
        public const string DATALENGTH = "DataLength";


        public string ConnectionString => arxConn.CONNECTIONSTRING;

        public int IdConnectionString => arxConn.ID;

        public ArxDb(string connectionString = "")
        {
            _hdToolDB = new HelpDeskToolsDb(HdToolConnectionString.ConnectionString);

            dmConnection = _hdToolDB.DM_CONNECTIONs;

            arxConn = string.IsNullOrEmpty(connectionString) ? dmConnection.FirstOrDefault() : dmConnection.FirstOrDefault(x => x.CONNECTIONSTRING == connectionString);
        }
        
        public DataTable ExtractTableName()
        { 
            return ExecuteQuery("ScriptNomeTabelle.sql", arxConn.CONNECTIONSTRING);
            
        }

        
        public DataTable ExtractStructureDatabase()
        {
            return ExecuteQuery("ScriptTabelle.sql", arxConn.CONNECTIONSTRING);
        }

    }
}
