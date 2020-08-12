using System;
using System.Data;
using System.Windows.Forms;
using helpDeskTools.Class.Database;

namespace helpDeskTools
{
    public partial class Main : Form
    {

        private DataTable TableResult = new DataTable();
        private string _TableNameSelected;
        private ArxDb arxDb = new ArxDb();
        private HDToolDB hdToolDb = new HDToolDB();
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
            TableResult = arxDb.ExtractTableName();
            Dgv_TableName.DataSource = arxDb.ExtractStructureDatabase();
            
        }


        private void Dgv_DescriptionTableName_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_TableName.SelectedCells.Count > 0)
            {
                LoadTableNameDescription();

                DataView dataView = new DataView(TableResult)
                {
                    RowFilter = string.Concat("TableName = '", _TableNameSelected, "'")
                };
                Dgv_TableRow.DataSource = dataView;
                Dgv_TableRow.Columns[0].Visible = false;
                
            }

        }

        private void Dgv_DescriptionTableRow_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_TableName.SelectedCells.Count > 0)
            {
                //LoadTableNameDescription();
                LoadRowDescription();

            }

        }


        private void btn_SaveDescriptionTableName_Click(object sender, EventArgs e)
        {
            HDToolDB hdToolDb = new HDToolDB();
            MessageBox.Show(
                hdToolDb.SaveArxDescriptionTable(_TableNameSelected, Rtb_TableNameDescription.Text, arxDb.ArxConnectionString)
                    ? "Errore durante il salvataggio della descrizione della tabella"
                    : "Descrizione tabella salvata con successo");
        }

        private void btn_CancelDescriptionTableName_Click(object sender, EventArgs e)
        {
            LoadTableNameDescription();
        }

        private void LoadTableNameDescription()
        {
            int selectedRowIndex = Dgv_TableName.SelectedCells[0].RowIndex;
            _TableNameSelected = Dgv_TableName.Rows[selectedRowIndex].Cells[0].Value.ToString();
            Lbl_TableName.Text = _TableNameSelected;
            Rtb_TableNameDescription.Text = hdToolDb.GetArxDescriptionTable(_TableNameSelected, arxDb.ArxConnectionString);
        }

        private void LoadRowDescription()
        {
            if(Dgv_TableRow.SelectedCells.Count == 0) return;
            int selectedRowIndex = Dgv_TableRow.SelectedCells[0].RowIndex;
            string rowNameSelected = Dgv_TableRow.Rows[selectedRowIndex].Cells[1].Value.ToString();
            lbl_NameDescriptionRow.Text = rowNameSelected;
            //GetArxDescriptionRow
            rtb_DescriptionRow.Text = hdToolDb.GetArxDescriptionRow(_TableNameSelected, rowNameSelected, arxDb.ArxConnectionString);

        }

        private void btn_SaveDescriptionRow_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = Dgv_TableRow.SelectedCells[0].RowIndex;
            string rowNameSelected = Dgv_TableRow.Rows[selectedRowIndex].Cells[1].Value.ToString();

            hdToolDb.SaveArxDescriptionRow(_TableNameSelected, rowNameSelected, rtb_DescriptionRow.Text,
                arxDb.ArxConnectionString);
        }
    }
}
