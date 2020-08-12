using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using helpDeskTools.Class.ConnectionString;

namespace helpDeskTools.Class.Database
{
    public class ArxDb : BaseDb
    {
        public ArxConnectionString ArxConnectionString = new ArxConnectionString();
        public DataTable ExtractTableName()
        {
            
            return ExecuteQuery("ScriptTabelle.sql", ArxConnectionString.ConnectionString);
        }

        public DataTable ExtractStructureDatabase()
        {
            return ExecuteQuery("ScriptNomeTabelle.sql", ArxConnectionString.ConnectionString);
        }

    }
}
