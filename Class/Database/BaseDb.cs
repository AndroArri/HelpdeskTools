using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace helpDeskTools.Class.Database
{
    public class BaseDb : IBaseDb
    {
        
        protected override DataTable ExecuteQuery(string scriptName,string connectionString)
        {
            try
            {
                
                string query;
                if (scriptName.Contains(".sql"))
                {
                    FileInfo script = new FileInfo(Path.GetFullPath(string.Concat("script\\", scriptName)));
                    query = script.OpenText().ReadToEnd();
                }
                else
                {
                    query = scriptName;
                }
                
                SqlConnection sqlconn = new SqlConnection(connectionString);
                SqlCommand comm = new SqlCommand(query, sqlconn);
                sqlconn.Open();
                SqlDataReader dataReader = comm.ExecuteReader();
                if (!dataReader.HasRows) return new DataTable();
                DataTable result = new DataTable();
                result.Load(dataReader);
                sqlconn.Close();
                return result;
            }
            catch (Exception e)
            {
                throw  new Exception(e.Message);
            }
        }


    }

}
