using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using helpDeskTools.Class.ConnectionString;
using helpDeskTools.Class.Database.HdToolDB;

namespace helpDeskTools.Class.Database
{
    public class ArxDb : BaseDb
    {
        HdToolDb hdToolDb = new HdToolDb();
        public DataTable ExtractTableName()
        { 
            return ExecuteQuery("ScriptNomeTabelle.sql", hdToolDb.LoadArxConnectionString());
        }

        public DataTable ExtractStructureDatabase()
        {
            return ExecuteQuery("ScriptTabelle.sql", hdToolDb.LoadArxConnectionString());
        }

    }
}
