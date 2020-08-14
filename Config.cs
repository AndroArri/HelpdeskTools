using System;
using System.Windows.Forms;
using helpDeskTools.Class.ConnectionString;
using helpDeskTools.Class.Database;
using helpDeskTools.Class.Database.HdToolDB;

namespace helpDeskTools
{
    public partial class Config : Form
    {

        private HdToolDb hdToolDb = new HdToolDb();

        public Config()
        {
            InitializeComponent();
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            txtAddress.Text = hdToolDb._arxConnectionString.DataSource;
            txtNameDb.Text = hdToolDb._arxConnectionString.InitialCatalog;
            txtUser.Text = hdToolDb._arxConnectionString.UserID;
            txtPwd.Text = hdToolDb._arxConnectionString.Password;
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
