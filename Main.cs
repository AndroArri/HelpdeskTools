using System;
using System.Data;
using System.Windows.Forms;
using helpDeskTools.Class.Database;
using helpDeskTools.Class.Database.HdToolDB;
using System.Data.Linq;
using System.Linq;
using ComponentFactory.Krypton.Toolkit;
using helpDeskTools.Class.ConnectionString;
using helpDeskTools.Class.Database.HdToolDB.PartialClass;

namespace helpDeskTools
{
    public partial class Main : Form
    {

        private string _TableNameSelected;
        private ArxDb arxDb = new ArxDb();
        private HelpDeskToolsDb hdToolDb = new HelpDeskToolsDb(HdToolConnectionString.ConnectionString);
        private DataTable tableName = new DataTable();
        private DataTable tableRow = new DataTable();
        private Timer _timer = new Timer();


        public Main()
        {
            InitializeComponent();
            tableRow = arxDb.ExtractStructureDatabase();
            tableName = arxDb.ExtractTableName();
            Dgv_TableName.DataSource = tableName;
            Dgv_TableRow.DataSource = tableRow;
            Dgv_TableRow.Columns[ArxDb.TABLENAME].Visible = false;
        }

        #region  buttons

        private void Btn_Config_Click(object sender, EventArgs e)
        {
            var frmConfig = new Config();
            frmConfig.ShowDialog(this);

        }

        private void btn_SaveDescriptionRow_Click(object sender, EventArgs e)
        {
            try
            {
                hdToolDb.SubmitChanges();
                KryptonMessageBox.Show(this, "Modifiche salvate corretamente", "Salvataggio riuscito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                KryptonMessageBox.Show(this, "Attenzione: Problema nel salvataggio", "Salvataggio ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

        private void btn_CancelDescriptionTableName_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void RefreshAll()
        {
            hdToolDb.Refresh(RefreshMode.OverwriteCurrentValues);
        }



        #endregion

        #region  Table selection changed

        private void Dgv_DescriptionTableName_SelectionChanged(object sender, EventArgs e)
        {

            if (Dgv_TableName.SelectedCells.Count == 0) return;
            int selectedRowIndex = Dgv_TableName.SelectedCells[0].RowIndex;
            _TableNameSelected = Dgv_TableName.Rows[selectedRowIndex].Cells[ArxDb.TABLENAME].Value.ToString();
            Lbl_TableName.Text = _TableNameSelected;
            Rtb_TableNameDescription.Text = hdToolDb.GetArxDescriptionTable(_TableNameSelected);
            
            
            DataView dataview = new DataView(tableRow)
            {
                RowFilter = string.Format("Tablename = '{0}'", _TableNameSelected)
            };
            Dgv_TableRow.DataSource = dataview;

            if (Dgv_TableRow.SelectedCells.Count != 0)
            {
                LoadRowDescription();
            }
            
        }

        private void LoadRowDescription()
        {
            int selectedRowIndex = Dgv_TableRow.SelectedCells[0].RowIndex;
            string rowNameSelected = Dgv_TableRow.Rows[selectedRowIndex].Cells[ArxDb.COLUMNNAME].Value.ToString();

            //GetArxDescriptionRow
            Rtb_DescriptionRow.Text = hdToolDb.GetArxDescriptionRow(_TableNameSelected, rowNameSelected);
            lbl_NameDescriptionRow.Text = rowNameSelected;
        }

        private void Dgv_DescriptionTableRow_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_TableRow.SelectedCells.Count > 0)
            {
                LoadRowDescription();
            }
        }

        private void Rtb_DescriptionRow_Leave(object sender, EventArgs e)
        {
            var rowIndex = Dgv_TableRow.SelectedCells[0].RowIndex;
            var descriptionSelected = Dgv_TableRow.Rows[rowIndex].Cells[1].Value;

            var tableIndex = Dgv_TableName.SelectedCells[0].RowIndex;
            string tableNameSelected = Dgv_TableName.Rows[tableIndex].Cells[ArxDb.TABLENAME].Value.ToString();

            int idTable = hdToolDb.GetIdDescriptionTable(tableNameSelected);
            try
            {
                

                hdToolDb.DM_ROWs.FirstOrDefault(x => x.ROW == descriptionSelected && x.ID_TABLE == idTable).DESCRIPTION = Rtb_DescriptionRow.Text;
            }
            catch (Exception exception)
            {
                //Se non trova la riga all'interno del database, perchè la descrizione è vuota, aggiungo la nuova descrizione
                string tableName = Dgv_TableName.SelectedCells[0].Value.ToString();
                hdToolDb.SaveArxDescriptionRow(arxDb.IdConnectionString, tableName, descriptionSelected.ToString(),
                    Rtb_DescriptionRow.Text);
            }

        }

        private void Rtb_TableNameDescription_Leave(object sender, EventArgs e)
        {
            var rowIndex = Dgv_TableName.SelectedCells[0].RowIndex;
            string tableNameSelected = Dgv_TableName.Rows[rowIndex].Cells[ArxDb.TABLENAME].Value.ToString();
            try
            {
                if (hdToolDb.DM_TABLEs != null)
                    hdToolDb.DM_TABLEs.FirstOrDefault(x => x.TABLENAME != null && x.TABLENAME == tableNameSelected)
                        .DESCRIPTION = Rtb_TableNameDescription.Text;
            }
            catch (Exception exception)
            {
                //Se non trova la tabella all'interno del database, perchè la descrizione è vuota, non faccio niente
                
                hdToolDb.SaveArxDescriptionTable(tableNameSelected, Rtb_TableNameDescription.Text, arxDb.IdConnectionString);
            }

        }

        #endregion

        #region  Filter Tables

        private void timer_FilterTable_tick(object sender, EventArgs e)
        {
            timer_FilterTable.Stop();
            if (txt_FindTable.Text.Length >= 1)
            {
                Dgv_TableName.DataSource = SetFilter(tableName, ArxDb.TABLENAME, txt_FindTable.Text);
            }
            else
            {
                Dgv_TableName.DataSource = tableName;
            }
        }

        private void timer_FilterRow_Tick(object sender, EventArgs e)
        {
            timer_FilterRow.Stop();
            if (txt_FilterRow.Text.Length >= 3)
            {
                Dgv_TableRow.DataSource = SetFilter(tableRow, ArxDb.COLUMNNAME, txt_FilterRow.Text);
            }
            else
            {
                Dgv_TableRow.DataSource = tableRow;
            }
        }
        private void txt_FindTable_TextChanged(object sender, EventArgs e)
        {
            timer_FilterTable.Stop();
            timer_FilterTable.Start();
        }

        private void txt_FilterRow_TextChanged(object sender, EventArgs e)
        {
            timer_FilterRow.Stop();
            timer_FilterRow.Start();
        }


        private DataView SetFilter(DataTable table, string columnToSearch, string txtToFind)
        {

            DataView dataView = new DataView(table)
            {
                RowFilter = string.Format("{0} LIKE '%{1}%'", columnToSearch, txtToFind)
            };

            return dataView;
        }


        #endregion
    }
}
