using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using helpDeskTools.Class.Database;

namespace helpDeskTools
{
    public partial class Config : Form
    {
        public BaseDb BaseDb { get; private set; }

        public Config()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BaseDb = new BaseDb();
            if (BaseDb.SetConnectionString(txtAddress.Text, txtNameDb.Text, txtUser.Text, txtPwd.Text))
            {
                MessageBox.Show("Stringa di connessione configurata correttamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Errore durante la configurazione della stringa di connessione");
            }

        }
    }
}
