using System;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace helpDeskTools.Class.Database.HdToolDB.PartialClass
{
    public partial class HelpDeskToolsDb : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        #region Extensibility Method Definitions

        partial void InsertDM_CONNECTION(DM_CONNECTION instance);
        partial void UpdateDM_CONNECTION(DM_CONNECTION instance);
        partial void DeleteDM_CONNECTION(DM_CONNECTION instance);
        partial void InsertDM_ROW(DM_ROW instance);
        partial void UpdateDM_ROW(DM_ROW instance);
        partial void DeleteDM_ROW(DM_ROW instance);
        partial void InsertDM_TABLE(DM_TABLE instance);
        partial void UpdateDM_TABLE(DM_TABLE instance);
        partial void DeleteDM_TABLE(DM_TABLE instance);
        #endregion

        public HelpDeskToolsDb(string connection) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public HelpDeskToolsDb(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public HelpDeskToolsDb(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public HelpDeskToolsDb(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public System.Data.Linq.Table<DM_CONNECTION> DM_CONNECTIONs
        {
            get
            {
                return this.GetTable<DM_CONNECTION>();
            }
        }

        public System.Data.Linq.Table<DM_ROW> DM_ROWs
        {
            get
            {
                return this.GetTable<DM_ROW>();
            }
        }

        public System.Data.Linq.Table<DM_TABLE> DM_TABLEs
        {
            get
            {
                return this.GetTable<DM_TABLE>();
            }
        }
        
        private void OnCreated()
        {

        }


        public bool SaveArxConnectionString(SqlConnectionStringBuilder connectionString)
        {
            try
            {
                IQueryable<DM_CONNECTION> idConnections =
                    from dmConnection in DM_CONNECTIONs
                    where dmConnection.CONNECTIONSTRING == connectionString.ConnectionString
                    select dmConnection;

                if (idConnections.Any()) return false;

                DM_CONNECTION dmConnectionInsert = new DM_CONNECTION
                {
                    CONNECTIONSTRING = connectionString.ConnectionString
                };

                DM_CONNECTIONs.InsertOnSubmit(dmConnectionInsert);
                SubmitChanges();
            }
            catch (Exception e)
            {
                return false;

            }

            return true;
        }

        public bool SaveArxConnectionString(string dataSource, string catalog, string user, string pwd)
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder()
            {
                DataSource = dataSource,
                InitialCatalog = catalog,
                UserID = user,
                Password = pwd
            };

            return SaveArxConnectionString(sqlConnection);
        }


        //Caricamento stringa connessione ARX
        public string GetArxConnectionString()
        {
            IQueryable<string> connectionString =
                from dmConnection in DM_CONNECTIONs
                orderby dmConnection.ID descending
                select dmConnection.CONNECTIONSTRING;

            return connectionString.FirstOrDefault();

        }

        //Recupero ID della connection
        public int GetIdArxConnectionString(string connectionString)
        {
            IQueryable<int> id =
                from dmConnection in DM_CONNECTIONs
                where dmConnection.CONNECTIONSTRING == connectionString
                select dmConnection.ID;
            return id.Any() ? 0 : id.FirstOrDefault();
        }

        public string GetConnectionStringFromId(int idConnectionString)
        {
            IQueryable<string> connectionString =
                from dmConnection in DM_CONNECTIONs
                where dmConnection.ID == idConnectionString
                select dmConnection.CONNECTIONSTRING;
            return connectionString.Any() ? "" : connectionString.FirstOrDefault();
        }


        //Recupero ID della descrizione tabella
        public int GetIdDescriptionTable(string tableName)
        {
            IQueryable<int> idDescriptionTable =
                from dmTable in DM_TABLEs
                where dmTable.TABLENAME == tableName
                select dmTable.ID;
            return idDescriptionTable.Any() ? idDescriptionTable.FirstOrDefault() : 0;

        }

        public int GetIdDescriptionRow(int idTableName, string row)
        {
            try
            {
                IQueryable<DM_ROW> idDescriptionRow = DM_ROWs.Where(x => x.ID_TABLE == idTableName && x.ROW == row);

                if (idDescriptionRow.Any()) return 0;

                return idDescriptionRow.FirstOrDefault().ID;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        //Salvataggio descrizione tabella
        public bool SaveArxDescriptionTable(string tableName, string description, int idConnectionString)
        {
            try
            {
                
                DM_TABLEs.InsertOnSubmit(new DM_TABLE()
                {
                    TABLENAME = tableName,
                    DESCRIPTION = description,
                    ID_CONNECTION = idConnectionString
                });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }

        public bool SaveArxDescriptionRow(int idConnectionString, string tableName, string row, string description)
        {
            try
            {
                IQueryable<DM_TABLE> dmTables = DM_TABLEs.Where(x => x.TABLENAME == tableName);

                if (dmTables.Any())
                {
                    IQueryable<DM_ROW> dmRows = DM_ROWs.Where(x => x.ID_TABLE == dmTables.FirstOrDefault().ID && x.ROW == row);
                    if (dmRows.Any())
                    {
                        dmRows.FirstOrDefault().DESCRIPTION = description;
                    }
                    else
                    {

                        DM_ROWs.InsertOnSubmit(new DM_ROW()
                        {
                            ID_TABLE = dmTables.FirstOrDefault().ID,
                            ROW = row,
                            DESCRIPTION = description
                        });
                    }

                }
                else
                {
                    if (SaveArxDescriptionTable(tableName, "", idConnectionString))
                    {
                        int idTable = GetIdDescriptionTable(tableName);
                        DM_ROWs.InsertOnSubmit(new DM_ROW()
                        {
                            ID_TABLE = idTable,
                            DESCRIPTION = description,
                            ROW = row
                        });
                    }

                }
                SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }


        public string GetArxDescriptionTable(string tableName)
        {
            try
            {
                IQueryable<DM_TABLE> dmTables = DM_TABLEs.Where(x => x.TABLENAME == tableName);

                if (!dmTables.Any()) return "";

                return dmTables.FirstOrDefault().DESCRIPTION;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetArxDescriptionRow(string tableName, string rowName)
        {
            try
            {
                IQueryable<DM_TABLE> dmTables = DM_TABLEs.Where(x => x.TABLENAME == tableName);
                int idTable = dmTables.FirstOrDefault().ID;

                IQueryable<DM_ROW> dmRows = DM_ROWs.Where(x => x.ROW == rowName && x.ID_TABLE == idTable);

                return !dmRows.Any() ? "" : dmRows.FirstOrDefault()?.DESCRIPTION;
            }
            catch (Exception e)
            {
                return "";
            }
        }


    }
}