using System;
using System.Windows.Forms;
using helpDeskTools.Class.ConnectionString;
using helpDeskTools.Class.Database;

namespace helpDeskTools
{
    public partial class Config : Form
    {
        private ArxConnectionString connString = new ArxConnectionString();
        private HDToolDB hdToolDb = new HDToolDB();

        public Config()
        {
            InitializeComponent();
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            connString.ConnectionString = hdToolDb.LoadArxConnectionString();
            txtAddress.Text = connString.ConnectionStringBuilder.DataSource;
            txtNameDb.Text = connString.ConnectionStringBuilder.InitialCatalog;
            txtUser.Text = connString.ConnectionStringBuilder.UserID;
            txtPwd.Text = connString.ConnectionStringBuilder.Password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (connString.SetConnectionString(txtAddress.Text, txtNameDb.Text, txtUser.Text, txtPwd.Text))
            {
                HDToolDB hdToolDb = new HDToolDB();
                MessageBox.Show(hdToolDb.SaveArxConnectionString(connString)
                    ? "Stringa di connessione configurata correttamente"
                    : "Stringa di connessione già presente all'interno del database");

                this.Close();
            }
            else
            {
                MessageBox.Show("Errore durante la configurazione della stringa di connessione");
            }

        }
    }
}
