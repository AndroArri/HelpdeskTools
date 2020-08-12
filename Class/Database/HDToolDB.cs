using System;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using helpDeskTools.Class.ConnectionString;

namespace helpDeskTools.Class.Database
{
    public class HDToolDB : BaseDb
    {
        public readonly HdToolConnectionString HdToolConnection = new HdToolConnectionString();

        #region const

        private const string DmConnection = "DM_CONNECTION";
        private const string DmRow = "DM_ROW";
        private const string dmTable = "DM_TABLE";

        #endregion

        //Salvataggio stringa connessione 
        public bool SaveArxConnectionString(ArxConnectionString connectionString)
        {

            string sqlVerify = string.Format("SELECT ID FROM {0} WHERE CONNECTIONSTRING='{1}'", DmConnection,connectionString.ConnectionString);

            DataTable verify = ExecuteQuery(sqlVerify, HdToolConnection.ConnectionString);
            if (verify.Rows.Count > 0) return false;

            string sql = string.Format("INSERT INTO {0} VALUES ('{1}')", DmConnection,
                connectionString.ConnectionString);
           return ExecuteQuery(sql, HdToolConnection.ConnectionString).HasErrors;
           
        }
        
        //Caricamento stringa connessione ARX
        public string LoadArxConnectionString()
        {
            string arxConnection = "";
            string sql = string.Format("SELECT TOP 1 * FROM {0} ORDER BY ID", DmConnection);
            DataTable res = ExecuteQuery(sql, HdToolConnection.ConnectionString);
            foreach (DataRow row in res.Rows)
            {
                arxConnection = row[1].ToString();
            }
            
            return arxConnection;
        }

        //Recupero ID della connection
        public int GetIdArxConnectionString(ArxConnectionString connectionString)
        {
            string sql = string.Format("SELECT ID FROM {0} WHERE CONNECTIONSTRING='{1}'", DmConnection,
                connectionString.ConnectionString);
            DataTable resultDataTable = ExecuteQuery(sql, HdToolConnection.ConnectionString);
            int id = 0;
            foreach (DataRow dataRow in resultDataTable.Rows)
            {
                id = (int) dataRow[0];
            }

            return id;
        }

        //Recupero ID della descrizione tabella
        public int GetIdDescriptionTable(string tableName)
        {
            string sql = string.Format("SELECT ID FROM {0} WHERE TABLENAME= '{1}'", dmTable, tableName);
            DataTable resultDataTable = ExecuteQuery(sql, HdToolConnection.ConnectionString);
            int id = 0;
            foreach (DataRow dataRow in resultDataTable.Rows)
            {
                id = (int) dataRow[0];
            }

            return id;
        }

        public int GetIdDescriptionRow(int idTableName, string row)
        {
            string sql = string.Format("SELECT ID FROM {0} WHERE ID_TABLE={1} AND ROW='{2}'", DmRow, idTableName, row);
            DataTable resultDataTable = ExecuteQuery(sql, HdToolConnection.ConnectionString);
            int id = 0;
            foreach (DataRow dataRow in resultDataTable.Rows)
            {
                id = (int) dataRow[0];
            }

            return id;
        }


        //Salvataggio descrizione tabella
        public bool SaveArxDescriptionTable(string tableName, string description, ArxConnectionString connectionString)
        {
            int idArxConnectionString = GetIdArxConnectionString(connectionString);
            if (idArxConnectionString == 0) return false;
            int idTableDescription = GetIdDescriptionTable(tableName);
            var sql = idTableDescription == 0
                ? String.Format("INSERT INTO {0} VALUES ({1},'{2}','{3}')", dmTable, idArxConnectionString, tableName,
                    description.Normalize()) :  
                String.Format("UPDATE {0} SET (DESCRIPTION='{1}') WHERE ID={2} ", dmTable, description, idTableDescription);

            return ExecuteQuery(sql, HdToolConnection.ConnectionString).HasErrors;
        }

        public bool SaveArxDescriptionRow(string tableName, string row, string description, ArxConnectionString connectionString)
        {
            int idTableName = GetIdDescriptionTable(tableName);
            if (idTableName == 0) return false;
            int idRow = GetIdDescriptionRow(idTableName, row);
            var sql = idRow == 0
                ? string.Format("INSERT INTO {0} VALUES ({1}, '{2}', '{3}')", DmRow, idTableName, row, description.Normalize())
                : string.Format("UPDATE {0} SET DESCRIPTION = '{1}' WHERE ID = {2}", DmRow, description, idRow);

            return ExecuteQuery(sql, HdToolConnection.ConnectionString).HasErrors;

        }


        public string GetArxDescriptionTable(string tableName, ArxConnectionString connectionString)
        {
            int idTableDescription = GetIdDescriptionTable(tableName);
            if (idTableDescription == 0) return "";
            string sql = string.Format("SELECT DESCRIPTION FROM {0} WHERE ID = {1}", dmTable, idTableDescription);
            DataTable resultDataTable = ExecuteQuery(sql, HdToolConnection.ConnectionString);
            string result = "";
            foreach (DataRow dataRow in resultDataTable.Rows)
            {
                result = dataRow[0].ToString();
            }

            return result;
        }

        public string GetArxDescriptionRow(string tableName, string rowName, ArxConnectionString connectionString)
        {
            int idTableDescription = GetIdDescriptionTable(tableName);
            if (idTableDescription == 0) return "";
            string sql = string.Format("SELECT DESCRIPTION FROM {0} WHERE ID_TABLE = {1} AND ROW = '{2}'", DmRow,
                idTableDescription, @rowName);
            DataTable resultDataTable = ExecuteQuery(sql, HdToolConnection.ConnectionString);
            string result = "";
            foreach (DataRow dataRow in resultDataTable.Rows)
            {
                result = dataRow[0].ToString();
            }

            return result;
        }

    }
}
