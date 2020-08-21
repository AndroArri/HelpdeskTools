using System;
using System.Data;
using System.Windows.Forms;
using helpDeskTools.Class.Database;
using helpDeskTools.Class.Database.HdToolDB;
using System.Data.Linq;
using System.Linq;

namespace helpDeskTools
{
    public partial class Main : Form
    {

        private string _TableNameSelected;
        private ArxDb arxDb = new ArxDb();
        private HdToolDb hdToolDb = new HdToolDb();
        private DataTable tableName = new DataTable();
        private DataTable tableRow = new DataTable();
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
            tableRow = arxDb.ExtractStructureDatabase();
            tableName = arxDb.ExtractTableName();
            Dgv_TableName.DataSource = tableName;

        }


        private void Dgv_DescriptionTableName_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_TableName.SelectedCells.Count > 0)
            {
                LoadTableNameDescription();
                DataView dataView = new DataView(tableRow)
                {
                    RowFilter = string.Format("TableName = '{0}'", _TableNameSelected)
                };
                Dgv_TableRow.DataSource = dataView;
                Dgv_TableRow.Columns[0].Visible = false;

            }

        }

        private void Dgv_DescriptionTableRow_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_TableName.SelectedCells.Count > 0)
            {
                LoadRowDescription();
            }

        }


        private void btn_SaveDescriptionTableName_Click(object sender, EventArgs e)
        {
            HdToolDb hdToolDb = new HdToolDb();
            MessageBox.Show(
                hdToolDb.SaveArxDescriptionTable(_TableNameSelected, Rtb_TableNameDescription.Text)
                    ? "Descrizione tabella salvata con successo"
                    : "Errore durante il salvataggio della descrizione della tabella");
        }

        private void btn_CancelDescriptionTableName_Click(object sender, EventArgs e)
        {
            LoadTableNameDescription();
        }

        private void LoadTableNameDescription()
        {
            if (Dgv_TableName.SelectedCells.Count == 0) return;

            int selectedRowIndex = Dgv_TableName.SelectedCells[0].RowIndex;
            _TableNameSelected = Dgv_TableName.Rows[selectedRowIndex].Cells[0].Value.ToString();
            Lbl_TableName.Text = _TableNameSelected;
            Rtb_TableNameDescription.Text = hdToolDb.GetArxDescriptionTable(_TableNameSelected);
        }

        private void LoadRowDescription()
        {
            if (Dgv_TableRow.SelectedCells.Count == 0) return;
            int selectedRowIndex = Dgv_TableRow.SelectedCells[0].RowIndex;
            string rowNameSelected = Dgv_TableRow.Rows[selectedRowIndex].Cells[1].Value.ToString();
            lbl_NameDescriptionRow.Text = rowNameSelected;
            //GetArxDescriptionRow
            rtb_DescriptionRow.Text = hdToolDb.GetArxDescriptionRow(_TableNameSelected, rowNameSelected);

        }

        private void btn_SaveDescriptionRow_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = Dgv_TableRow.SelectedCells[0].RowIndex;
            string rowNameSelected = Dgv_TableRow.Rows[selectedRowIndex].Cells[1].Value.ToString();

            hdToolDb.SaveArxDescriptionRow(_TableNameSelected, rowNameSelected, rtb_DescriptionRow.Text);
        }

        private void txt_FindTable_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_FindTable.Text.Length >= 1)
                {
                    DataView dataView = new DataView(tableName)
                    {
                        RowFilter = string.Format("TableName LIKE '%{0}%'", txt_FindTable.Text)
                    };
                    Dgv_TableName.DataSource = dataView;
                }
                else if (txt_FindTable.Text.Length == 0)
                {
                    Dgv_TableName.DataSource = tableName;
                }

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void txt_FilterRow_TextChanged(object sender, EventArgs e)
        {
            if (txt_FilterRow.Text.Length >= 2)
            {
                DataView dataView = new DataView(tableRow)
                {
                    RowFilter = string.Format("ColumnName = '{0}'", txt_FilterRow.Text)
                };
                if (dataView.Count == 0) return;
                
                string filter = "TableName IN ({0})";
                string element = "";

                foreach (DataRowView dataRowView in dataView)
                {
                    element = string.Concat(element, string.Format("'{0}',", dataRowView["TableName"]));    
                }

                filter = string.Format(filter, element);
                filter = filter.Remove(filter.LastIndexOf(","), 1);

                DataView dataViewTableName = new DataView(tableName)
                {
                    RowFilter = filter
                };

                Dgv_TableName.DataSource = dataViewTableName;
            }
            else
            {
                Dgv_TableName.DataSource = tableName;
            }
        }
    }
}
