using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 

namespace helpDeskTools.Class.Database
{
    public class BaseDb : IBaseDb
    {
        private string _connectionString;
        public  string TableName;
        public string ColumnName;
        public string DataType;
        public int DataLength;


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

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        public override DataTable ExtractStructureDatabase()
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                FileInfo script = new FileInfo(Path.GetFullPath("script\\EstrapolazioneTabelle.sql"));
                string query = script.OpenText().ReadToEnd();
                SqlCommand comm = new SqlCommand(query, sqlconn);
                sqlconn.Open();
                SqlDataReader dataReader = comm.ExecuteReader();
                if(!dataReader.HasRows) return  new DataTable();

                DataTable result = new DataTable();
                result.Load(dataReader);
                sqlconn.Close();
                return result;
            }
            catch (Exception e)
            {
                return new DataTable();
            }
        }
    }

}
