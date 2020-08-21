using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using helpDeskTools.Class.ConnectionString;
using helpDeskTools.Class.Database.HdToolDB.PartialClass;

namespace helpDeskTools.Class.Database.HdToolDB
{
    public class HdToolDb
    {
        public readonly HdToolConnectionString _hdToolConnection = new HdToolConnectionString();
        public readonly SqlConnectionStringBuilder _arxConnectionString = new SqlConnectionStringBuilder();
        private DataContext _hdToolDb;
        private Table<DM_CONNECTION> _dmConnections;
        private Table<DM_TABLE> _dmTables;
        private Table<DM_ROW> _dmRows;

        public HdToolDb()
        {
            RefreshDataFromDb();
        }


        //Salvataggio stringa connessione 
        public bool SaveArxConnectionString(SqlConnectionStringBuilder connectionString)
        {
            try
            {
                IQueryable<DM_CONNECTION> idConnections =
                    from dmConnection in _dmConnections
                    where dmConnection.CONNECTIONSTRING == connectionString.ConnectionString
                    select dmConnection;

                if (idConnections.Any()) return false;

                DM_CONNECTION dmConnectionInsert = new DM_CONNECTION
                {
                    CONNECTIONSTRING = connectionString.ConnectionString
                };

                _dmConnections.InsertOnSubmit(dmConnectionInsert);
                _hdToolDb.SubmitChanges();
                RefreshDataFromDb();

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
        public string LoadArxConnectionString()
        {
            IQueryable<string> connectionString =
                from dmConnection in _dmConnections
                orderby dmConnection.ID descending
                select dmConnection.CONNECTIONSTRING;

            return connectionString.FirstOrDefault();

        }

        //Recupero ID della connection
        public int GetIdArxConnectionString()
        {
            IQueryable<int> id =
                from dmConnection in _dmConnections
                where dmConnection.CONNECTIONSTRING == _arxConnectionString.ConnectionString
                select dmConnection.ID;
            return id.Any() ? 0 : id.FirstOrDefault();
        }

        //Recupero ID della descrizione tabella
        public int GetIdDescriptionTable(string tableName)
        {
            IQueryable<int> idDescriptionTable =
                from dmTable in _dmTables
                where dmTable.TABLENAME == tableName
                select dmTable.ID;
            return idDescriptionTable.Any() ? idDescriptionTable.FirstOrDefault() : 0;

        }

        public int GetIdDescriptionRow(int idTableName, string row)
        {
            try
            {
                IQueryable<DM_ROW> idDescriptionRow = _dmRows.Where(x => x.ID_TABLE == idTableName && x.ROW == row);

                if (idDescriptionRow.Any()) return 0;

                return idDescriptionRow.FirstOrDefault().ID;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        //Salvataggio descrizione tabella
        public bool SaveArxDescriptionTable(string tableName, string description)
        {
            try
            {
                IQueryable<DM_TABLE> dmTables = _dmTables.Where(x => x.TABLENAME == tableName);
                if (dmTables.Any())
                {
                    dmTables.FirstOrDefault().DESCRIPTION = description;
                }
                else
                {
                    IQueryable<DM_CONNECTION> idConnections =
                        _dmConnections.Where(x => x.CONNECTIONSTRING == _arxConnectionString.ConnectionString);
                    if (idConnections.Any())
                    {
                        _dmTables.InsertOnSubmit(new DM_TABLE
                        {
                            DESCRIPTION = description,
                            ID_CONNECTION = idConnections.FirstOrDefault().ID,
                            TABLENAME = tableName
                        });

                    }
                }
                _hdToolDb.SubmitChanges();
                RefreshDataFromDb();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }

        private void RefreshDataFromDb()
        {
            _hdToolDb?.Dispose();
            _hdToolDb = new DataContext(_hdToolConnection.ConnectionString);
            _dmConnections = _hdToolDb.GetTable<DM_CONNECTION>();
            _dmTables = _hdToolDb.GetTable<DM_TABLE>();
            _dmRows = _hdToolDb.GetTable<DM_ROW>();
            _arxConnectionString.ConnectionString = LoadArxConnectionString();
        }



        public bool SaveArxDescriptionRow(string tableName, string row, string description)
        {
            try
            {
                IQueryable<DM_TABLE> dmTables = _dmTables.Where(x => x.TABLENAME == tableName);

                if (dmTables.Any())
                {
                    IQueryable<DM_ROW> dmRows = _dmRows.Where(x => x.ID_TABLE == dmTables.FirstOrDefault().ID && x.ROW == row);
                    if (dmRows.Any())
                    {
                        dmRows.FirstOrDefault().DESCRIPTION = description;
                    }
                    else
                    {
                        
                        _dmRows.InsertOnSubmit(new DM_ROW()
                        {
                            ID_TABLE = dmTables.FirstOrDefault().ID,
                            ROW = row,
                            DESCRIPTION = description
                        });
                    }
                    
                }
                else
                {
                    if (SaveArxDescriptionTable(tableName, ""))
                    {
                        int idTable = GetIdDescriptionTable(tableName);
                        _dmRows.InsertOnSubmit(new DM_ROW()
                        {
                            ID_TABLE = idTable,
                            DESCRIPTION = description,
                            ROW = row
                        });
                    }

                }
                _hdToolDb.SubmitChanges();
                RefreshDataFromDb();
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
                IQueryable<DM_TABLE> dmTables = _dmTables.Where(x => x.TABLENAME == tableName);

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
                IQueryable<DM_TABLE> dmTables = _dmTables.Where(x => x.TABLENAME == tableName);

                IQueryable<DM_ROW> dmRows = _dmRows.Where(x => (x.ROW == rowName) && (x.ID_TABLE == dmTables.FirstOrDefault().ID));

                if (!dmRows.Any()) return "";

                return dmRows.FirstOrDefault().DESCRIPTION;

            }
            catch (Exception e)
            {
                return "";
            }
        }

    }
}
