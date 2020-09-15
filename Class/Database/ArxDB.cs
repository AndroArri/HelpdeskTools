using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using helpDeskTools.Class.ConnectionString;
using helpDeskTools.Class.Database.HdToolDB;
using helpDeskTools.Class.Database.HdToolDB.PartialClass;

namespace helpDeskTools.Class.Database
{
    public class ArxDb : BaseDb
    {

        private HelpDeskToolsDb _hdToolDB;
        private ArxConnectionString _arxConnection;

        public string ConnectionString => _arxConnection.ConnectionString;

        public int IdConnectionString => _arxConnection.Id;

        public ArxDb()
        {
            _hdToolDB = new HelpDeskToolsDb(HdToolConnectionString.ConnectionString);
            _arxConnection = new ArxConnectionString(_hdToolDB);
        }
        
        public DataTable ExtractTableName()
        { 
            return ExecuteQuery("ScriptNomeTabelle.sql", _arxConnection.ConnectionString);
        }

        public DataTable ExtractStructureDatabase()
        {
            return ExecuteQuery("ScriptTabelle.sql",_arxConnection.ConnectionString);
        }

    }
}
