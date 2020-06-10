using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace helpDeskTools.Class.Database
{
    public class BaseDb : IBaseDb
    {
        private string _connectionString;

        public override string ConnectionString
        {
            get =>_connectionString ?? (_connectionString = Properties.Settings.Default.ConnectionString);
            internal set
            {
                Properties.Settings.Default.ConnectionString = value;
                Properties.Settings.Default.Save();
            } 
        }

        public bool SetConnectionString(string addressDb, string database, string username, string pwd)
        {
            try
            {
                ConnectionString =
                    $"Provider = SQLNCLI11; Server = {addressDb}; Database = {database}; Uid = {username}; Pwd = {pwd};";
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        public override DataSet ExtractStructureDatabase()
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(_connectionString);
                FileInfo script = new FileInfo(Path.GetFullPath("script\\EstrapolazioneTabelle.sql"));
                string query = script.OpenText().ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            return new DataSet();
        }
    }

}
