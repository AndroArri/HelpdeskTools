using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace helpDeskTools.Class.Database
{
    class BaseDb : IBaseDb
    {
        public string ConnectionString;

        public BaseDb(string addressDb, string database, string username, string pwd)
        {
            ConnectionString =
                $"Provider = SQLNCLI11; Server = {addressDb}; Database = {database}; Uid = {username}; Pwd = {pwd};";
        }

        private DataSet ExtractStructureDatabase(string dbName)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            FileInfo script = new FileInfo(Path.GetFullPath("script\\EstrapolazioneTabelle.sql"));
            string query = script.OpenText().ReadToEnd();


            return new DataSet();
        }
    }
}
