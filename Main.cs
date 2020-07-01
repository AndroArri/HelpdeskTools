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
            Dgv_Table.DataSource = baseDb.ExtractStructureDatabase();
            Dgv_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        }

        private void Dgv_Table_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Table.SelectedCells.Count > 0)
            {
                int selectedRowIndex = Dgv_Table.SelectedCells[0].RowIndex;
                Lbl_TableName.Text = Dgv_Table.Rows[selectedRowIndex].Cells[0].Value.ToString();
            }
        

    }
    }
}
