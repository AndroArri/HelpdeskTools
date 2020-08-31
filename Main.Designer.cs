namespace helpDeskTools
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_LoadDb = new System.Windows.Forms.Button();
            this.Lbl_TableName = new System.Windows.Forms.Label();
            this.lbl_NameDescriptionRow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Config = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_FindTable = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Dgv_TableName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Dgv_TableRow = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Rtb_TableNameDescription = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.Rtb_DescriptionRow = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.btn_SaveTableNameDescription = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_CancelDescriptionTableName = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_SaveDescriptionRow = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Navigator = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.Documentazione = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.txt_FilterRow = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Documentazione)).BeginInit();
            this.Documentazione.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_LoadDb
            // 
            this.Btn_LoadDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_LoadDb.Location = new System.Drawing.Point(-209, -250);
            this.Btn_LoadDb.Name = "Btn_LoadDb";
            this.Btn_LoadDb.Size = new System.Drawing.Size(75, 23);
            this.Btn_LoadDb.TabIndex = 1;
            this.Btn_LoadDb.Text = "Carica DB";
            this.Btn_LoadDb.UseVisualStyleBackColor = true;
            // 
            // Lbl_TableName
            // 
            this.Lbl_TableName.AutoSize = true;
            this.Lbl_TableName.Location = new System.Drawing.Point(305, 42);
            this.Lbl_TableName.Name = "Lbl_TableName";
            this.Lbl_TableName.Size = new System.Drawing.Size(69, 13);
            this.Lbl_TableName.TabIndex = 4;
            this.Lbl_TableName.Text = "Nome tabella";
            // 
            // lbl_NameDescriptionRow
            // 
            this.lbl_NameDescriptionRow.AutoSize = true;
            this.lbl_NameDescriptionRow.Location = new System.Drawing.Point(906, 42);
            this.lbl_NameDescriptionRow.Name = "lbl_NameDescriptionRow";
            this.lbl_NameDescriptionRow.Size = new System.Drawing.Size(55, 13);
            this.lbl_NameDescriptionRow.TabIndex = 9;
            this.lbl_NameDescriptionRow.Text = "Nome riga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filtro tabella";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filtro riga";
            // 
            // Btn_Config
            // 
            this.Btn_Config.Location = new System.Drawing.Point(16, 3);
            this.Btn_Config.Name = "Btn_Config";
            this.Btn_Config.Size = new System.Drawing.Size(90, 25);
            this.Btn_Config.TabIndex = 16;
            this.Btn_Config.Values.Text = "Impostazioni";
            this.Btn_Config.Click += new System.EventHandler(this.Btn_Config_Click);
            // 
            // txt_FindTable
            // 
            this.txt_FindTable.Location = new System.Drawing.Point(7, 29);
            this.txt_FindTable.Name = "txt_FindTable";
            this.txt_FindTable.Size = new System.Drawing.Size(295, 23);
            this.txt_FindTable.TabIndex = 17;
            this.txt_FindTable.TextChanged += new System.EventHandler(this.txt_FindTable_TextChanged);
            // 
            // Dgv_TableName
            // 
            this.Dgv_TableName.AllowUserToAddRows = false;
            this.Dgv_TableName.AllowUserToDeleteRows = false;
            this.Dgv_TableName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_TableName.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_TableName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TableName.Location = new System.Drawing.Point(7, 58);
            this.Dgv_TableName.Name = "Dgv_TableName";
            this.Dgv_TableName.ReadOnly = true;
            this.Dgv_TableName.Size = new System.Drawing.Size(295, 384);
            this.Dgv_TableName.TabIndex = 18;
            this.Dgv_TableName.SelectionChanged += new System.EventHandler(this.Dgv_DescriptionTableName_SelectionChanged);
            // 
            // Dgv_TableRow
            // 
            this.Dgv_TableRow.AllowUserToAddRows = false;
            this.Dgv_TableRow.AllowUserToDeleteRows = false;
            this.Dgv_TableRow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_TableRow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_TableRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TableRow.Location = new System.Drawing.Point(545, 58);
            this.Dgv_TableRow.MultiSelect = false;
            this.Dgv_TableRow.Name = "Dgv_TableRow";
            this.Dgv_TableRow.ReadOnly = true;
            this.Dgv_TableRow.RowHeadersWidth = 5;
            this.Dgv_TableRow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dgv_TableRow.Size = new System.Drawing.Size(355, 384);
            this.Dgv_TableRow.TabIndex = 19;
            this.Dgv_TableRow.SelectionChanged += new System.EventHandler(this.Dgv_DescriptionTableRow_SelectionChanged);
            // 
            // Rtb_TableNameDescription
            // 
            this.Rtb_TableNameDescription.Location = new System.Drawing.Point(308, 58);
            this.Rtb_TableNameDescription.Name = "Rtb_TableNameDescription";
            this.Rtb_TableNameDescription.Size = new System.Drawing.Size(219, 178);
            this.Rtb_TableNameDescription.TabIndex = 20;
            this.Rtb_TableNameDescription.Text = "";
            // 
            // Rtb_DescriptionRow
            // 
            this.Rtb_DescriptionRow.Location = new System.Drawing.Point(909, 58);
            this.Rtb_DescriptionRow.Name = "Rtb_DescriptionRow";
            this.Rtb_DescriptionRow.Size = new System.Drawing.Size(219, 178);
            this.Rtb_DescriptionRow.TabIndex = 21;
            this.Rtb_DescriptionRow.Text = "";
            // 
            // btn_SaveTableNameDescription
            // 
            this.btn_SaveTableNameDescription.Location = new System.Drawing.Point(334, 242);
            this.btn_SaveTableNameDescription.Name = "btn_SaveTableNameDescription";
            this.btn_SaveTableNameDescription.Size = new System.Drawing.Size(90, 25);
            this.btn_SaveTableNameDescription.TabIndex = 22;
            this.btn_SaveTableNameDescription.Values.Text = "Salva";
            this.btn_SaveTableNameDescription.Click += new System.EventHandler(this.btn_SaveDescriptionTableName_Click);
            // 
            // btn_CancelDescriptionTableName
            // 
            this.btn_CancelDescriptionTableName.Location = new System.Drawing.Point(437, 242);
            this.btn_CancelDescriptionTableName.Name = "btn_CancelDescriptionTableName";
            this.btn_CancelDescriptionTableName.Size = new System.Drawing.Size(90, 25);
            this.btn_CancelDescriptionTableName.TabIndex = 23;
            this.btn_CancelDescriptionTableName.Values.Text = "Annulla";
            this.btn_CancelDescriptionTableName.Click += new System.EventHandler(this.btn_CancelDescriptionTableName_Click);
            // 
            // btn_SaveDescriptionRow
            // 
            this.btn_SaveDescriptionRow.Location = new System.Drawing.Point(1038, 242);
            this.btn_SaveDescriptionRow.Name = "btn_SaveDescriptionRow";
            this.btn_SaveDescriptionRow.Size = new System.Drawing.Size(90, 25);
            this.btn_SaveDescriptionRow.TabIndex = 24;
            this.btn_SaveDescriptionRow.Values.Text = "Salva";
            this.btn_SaveDescriptionRow.Click += new System.EventHandler(this.btn_SaveDescriptionRow_Click);
            // 
            // Navigator
            // 
            this.Navigator.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.Navigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.Navigator.Location = new System.Drawing.Point(12, 34);
            this.Navigator.Name = "Navigator";
            this.Navigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.Documentazione});
            this.Navigator.SelectedIndex = 0;
            this.Navigator.Size = new System.Drawing.Size(1145, 487);
            this.Navigator.TabIndex = 25;
            // 
            // Documentazione
            // 
            this.Documentazione.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.Documentazione.Controls.Add(this.txt_FilterRow);
            this.Documentazione.Controls.Add(this.txt_FindTable);
            this.Documentazione.Controls.Add(this.btn_SaveDescriptionRow);
            this.Documentazione.Controls.Add(this.Dgv_TableName);
            this.Documentazione.Controls.Add(this.btn_CancelDescriptionTableName);
            this.Documentazione.Controls.Add(this.label1);
            this.Documentazione.Controls.Add(this.btn_SaveTableNameDescription);
            this.Documentazione.Controls.Add(this.Rtb_TableNameDescription);
            this.Documentazione.Controls.Add(this.Rtb_DescriptionRow);
            this.Documentazione.Controls.Add(this.Lbl_TableName);
            this.Documentazione.Controls.Add(this.lbl_NameDescriptionRow);
            this.Documentazione.Controls.Add(this.Dgv_TableRow);
            this.Documentazione.Controls.Add(this.label2);
            this.Documentazione.Flags = 65534;
            this.Documentazione.LastVisibleSet = true;
            this.Documentazione.MinimumSize = new System.Drawing.Size(50, 50);
            this.Documentazione.Name = "Documentazione";
            this.Documentazione.Size = new System.Drawing.Size(1143, 460);
            this.Documentazione.Text = "Documentazione DB";
            this.Documentazione.ToolTipTitle = "Page ToolTip";
            this.Documentazione.UniqueName = "1F111C0C1B8B410AA4AE84837D86134C";
            // 
            // txt_FilterRow
            // 
            this.txt_FilterRow.Location = new System.Drawing.Point(545, 32);
            this.txt_FilterRow.Name = "txt_FilterRow";
            this.txt_FilterRow.Size = new System.Drawing.Size(355, 23);
            this.txt_FilterRow.TabIndex = 25;
            this.txt_FilterRow.TextChanged += new System.EventHandler(this.txt_FilterRow_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 542);
            this.Controls.Add(this.Navigator);
            this.Controls.Add(this.Btn_Config);
            this.Controls.Add(this.Btn_LoadDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Documentazione)).EndInit();
            this.Documentazione.ResumeLayout(false);
            this.Documentazione.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_LoadDb;
        private System.Windows.Forms.Label Lbl_TableName;
        private System.Windows.Forms.Label lbl_NameDescriptionRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Config;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_FindTable;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView Dgv_TableName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView Dgv_TableRow;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox Rtb_TableNameDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox Rtb_DescriptionRow;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_SaveTableNameDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_CancelDescriptionTableName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_SaveDescriptionRow;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator Navigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage Documentazione;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_FilterRow;
    }
}

