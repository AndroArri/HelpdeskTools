using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace helpDeskTools.Class.Database
{
    public abstract class IBaseDb
    {
        public string TableName;
        public string ColumnName;
        public string DataType;
        public int DataLength;
        public abstract string ConnectionString { get; internal set; }
        public abstract DataSet ExtractStructureDatabase();
    }
}
