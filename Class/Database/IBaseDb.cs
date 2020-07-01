using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace helpDeskTools.Class.Database
{
    public abstract class IBaseDb
    {
        public string TableName { get; internal set; }
        public string ColumnName { get; internal set; }
        public string DataType { get; internal set; }
        public int DataLength { get; internal set; }
        public abstract string ConnectionString { get; internal set; }
        public abstract DataTable ExtractStructureDatabase();
    }
}
