using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using helpDeskTools.Class.Database;

namespace helpDeskTools
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void Btn_Config_Click(object sender, EventArgs e)
        {
            var frmConfig = new Config();
            frmConfig.ShowDialog(this);
        }

        private void Btn_LoadDb_Click(object sender, EventArgs e)
        {
            IBaseDb baseDb = new BaseDb();
            baseDb.ExtractStructureDatabase();


        }
    }
}
