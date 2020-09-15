using System;
using System.Data;
using System.Windows.Forms;
using helpDeskTools.Class.ConnectionString;
using helpDeskTools.Class.Database;
using helpDeskTools.Class.Database.HdToolDB;
using helpDeskTools.Class.Database.HdToolDB.PartialClass;

namespace helpDeskTools
{
    public partial class Config : Form
    {

        private HelpDeskToolsDb hdToolDb;
        private DataTable dmConnection = new DataTable();

        public Config()
        {
            InitializeComponent();
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            
            hdToolDb = new HelpDeskToolsDb(HdToolConnectionString.ConnectionString);
            dgv_ConnectionList.DataSource = hdToolDb.DM_CONNECTIONs;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hdToolDb.SaveArxConnectionString(txtAddress.Text, txtNameDb.Text, txtUser.Text, txtPwd.Text)
                ? "Stringa di connessione configurata correttamente"
                : "Stringa di connessione già presente all'interno del database");

            this.Close();


        }
    }
}
