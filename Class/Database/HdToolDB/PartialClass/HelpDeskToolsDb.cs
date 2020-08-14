using System.Data.Linq.Mapping;

namespace helpDeskTools.Class.Database.HdToolDB.PartialClass
{
    public partial class HelpDeskToolsDb : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        #region Extensibility Method Definitions
        partial void OnCreated();
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
    }
}