using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace helpDeskTools.Class.Database
{
    internal abstract class IBaseDb
    {
        public string TableName;
        public string ColumnName;
        public string DataType;
        public int DataLength;
    }
}
