using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace helpDeskTools.Class.Database
{
    public class HelpDeskToolsDb : BaseDb
    {
        #region const

        #region TableName
        private const string DmConnection = "DM_CONNECTION";
        private const string DmRow = "DM_ROW";
        private const string DmTable = "DM_TABLE";
        #endregion

        #region query

        private static readonly string QuerySaveConnectionString = string.Format("INSERT INTO {0} SET ", DmConnection);
        private static readonly string QuerySaveDescriptionRow = string.Format("INSERT INTO {0} SET ", DmRow);
        private static readonly string QuerySaveDescriptionTable = string.Format("INSERT INTO {0} SET ", DmTable);
        #endregion

        #endregion


        //Salva connection string
        public bool SaveConnectionString()
        {
            
            return true;
        }
        //Leggi connection string
        public string ReadConnectionString()
        {
            return "";
        }


        //Salva descrizione riga
        public bool SaveDescriptionRow()
        {
            return true;
        }

        //Salva descrizione tabella
        public bool SaveDescriptionTable()
        {
            return true;
        }
    }
}
