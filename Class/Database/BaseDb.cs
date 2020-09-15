using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;

namespace helpDeskTools.Class.Database
{
    public class BaseDb : IBaseDb
    {

        protected override DataTable ExecuteQuery(string scriptName, string connectionString)
        {
            try
            {

                string query;

                FileInfo script = new FileInfo(Path.GetFullPath(string.Concat("script\\", scriptName)));
                query = script.OpenText().ReadToEnd();

                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    sqlconn.Open();

                    var dt = ExecuteQuerySelect(sqlconn, query);

                    return dt;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // esecuzione query di SELECT e restituzione DataTable
        private DataTable ExecuteQuerySelect(DbConnection connection, string query)
        {
            // inizializzo il datatable
            DataTable dt = new DataTable();
            try
            {
                var sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = query;
                using (DbDataReader reader = sqlCommand.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errore nell'esecuzione della query \"" + query + "\": " + ex.Message);
            }

            // restituisco il risultato
            return dt;
        }


    }

}
