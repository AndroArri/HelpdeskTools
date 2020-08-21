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
            this.Btn_Config = new System.Windows.Forms.Button();
            this.Btn_LoadDb = new System.Windows.Forms.Button();
            this.Rtb_TableNameDescription = new System.Windows.Forms.RichTextBox();
            this.Lbl_TableName = new System.Windows.Forms.Label();
            this.Dgv_TableName = new System.Windows.Forms.DataGridView();
            this.Dgv_TableRow = new System.Windows.Forms.DataGridView();
            this.btn_SaveTableNameDescription = new System.Windows.Forms.Button();
            this.btn_CancelDescriptionTableName = new System.Windows.Forms.Button();
            this.rtb_DescriptionRow = new System.Windows.Forms.RichTextBox();
            this.lbl_NameDescriptionRow = new System.Windows.Forms.Label();
            this.btn_CancelDescriptionRow = new System.Windows.Forms.Button();
            this.btn_SaveDescriptionRow = new System.Windows.Forms.Button();
            this.txt_FindTable = new System.Windows.Forms.TextBox();
            this.txt_FilterRow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableRow)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Config
            // 
            this.Btn_Config.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Config.Location = new System.Drawing.Point(12, 15);
            this.Btn_Config.Name = "Btn_Config";
            this.Btn_Config.Size = new System.Drawing.Size(75, 23);
            this.Btn_Config.TabIndex = 0;
            this.Btn_Config.Text = "Impostazioni";
            this.Btn_Config.UseVisualStyleBackColor = true;
            this.Btn_Config.Click += new System.EventHandler(this.Btn_Config_Click);
            // 
            // Btn_LoadDb
            // 
            this.Btn_LoadDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_LoadDb.Location = new System.Drawing.Point(93, 15);
            this.Btn_LoadDb.Name = "Btn_LoadDb";
            this.Btn_LoadDb.Size = new System.Drawing.Size(75, 23);
            this.Btn_LoadDb.TabIndex = 1;
            this.Btn_LoadDb.Text = "Carica DB";
            this.Btn_LoadDb.UseVisualStyleBackColor = true;
            this.Btn_LoadDb.Click += new System.EventHandler(this.Btn_LoadDb_Click);
            // 
            // Rtb_TableNameDescription
            // 
            this.Rtb_TableNameDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rtb_TableNameDescription.Location = new System.Drawing.Point(313, 110);
            this.Rtb_TableNameDescription.Name = "Rtb_TableNameDescription";
            this.Rtb_TableNameDescription.Size = new System.Drawing.Size(300, 384);
            this.Rtb_TableNameDescription.TabIndex = 3;
            this.Rtb_TableNameDescription.Text = "";
            // 
            // Lbl_TableName
            // 
            this.Lbl_TableName.AutoSize = true;
            this.Lbl_TableName.Location = new System.Drawing.Point(313, 94);
            this.Lbl_TableName.Name = "Lbl_TableName";
            this.Lbl_TableName.Size = new System.Drawing.Size(69, 13);
            this.Lbl_TableName.TabIndex = 4;
            this.Lbl_TableName.Text = "Nome tabella";
            // 
            // Dgv_TableName
            // 
            this.Dgv_TableName.AllowUserToAddRows = false;
            this.Dgv_TableName.AllowUserToDeleteRows = false;
            this.Dgv_TableName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_TableName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TableName.Location = new System.Drawing.Point(12, 94);
            this.Dgv_TableName.MultiSelect = false;
            this.Dgv_TableName.Name = "Dgv_TableName";
            this.Dgv_TableName.ReadOnly = true;
            this.Dgv_TableName.Size = new System.Drawing.Size(295, 677);
            this.Dgv_TableName.TabIndex = 5;
            this.Dgv_TableName.SelectionChanged += new System.EventHandler(this.Dgv_DescriptionTableName_SelectionChanged);
            // 
            // Dgv_TableRow
            // 
            this.Dgv_TableRow.AllowUserToAddRows = false;
            this.Dgv_TableRow.AllowUserToDeleteRows = false;
            this.Dgv_TableRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_TableRow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_TableRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TableRow.Location = new System.Drawing.Point(674, 94);
            this.Dgv_TableRow.Name = "Dgv_TableRow";
            this.Dgv_TableRow.Size = new System.Drawing.Size(441, 677);
            this.Dgv_TableRow.TabIndex = 2;
            this.Dgv_TableRow.SelectionChanged += new System.EventHandler(this.Dgv_DescriptionTableRow_SelectionChanged);
            // 
            // btn_SaveTableNameDescription
            // 
            this.btn_SaveTableNameDescription.Location = new System.Drawing.Point(442, 500);
            this.btn_SaveTableNameDescription.Name = "btn_SaveTableNameDescription";
            this.btn_SaveTableNameDescription.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveTableNameDescription.TabIndex = 6;
            this.btn_SaveTableNameDescription.Text = "salva";
            this.btn_SaveTableNameDescription.UseVisualStyleBackColor = true;
            this.btn_SaveTableNameDescription.Click += new System.EventHandler(this.btn_SaveDescriptionTableName_Click);
            // 
            // btn_CancelDescriptionTableName
            // 
            this.btn_CancelDescriptionTableName.Location = new System.Drawing.Point(538, 500);
            this.btn_CancelDescriptionTableName.Name = "btn_CancelDescriptionTableName";
            this.btn_CancelDescriptionTableName.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelDescriptionTableName.TabIndex = 7;
            this.btn_CancelDescriptionTableName.Text = "Cancella";
            this.btn_CancelDescriptionTableName.UseVisualStyleBackColor = true;
            this.btn_CancelDescriptionTableName.Click += new System.EventHandler(this.btn_CancelDescriptionTableName_Click);
            // 
            // rtb_DescriptionRow
            // 
            this.rtb_DescriptionRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtb_DescriptionRow.Location = new System.Drawing.Point(1121, 110);
            this.rtb_DescriptionRow.Name = "rtb_DescriptionRow";
            this.rtb_DescriptionRow.Size = new System.Drawing.Size(300, 384);
            this.rtb_DescriptionRow.TabIndex = 8;
            this.rtb_DescriptionRow.Text = "";
            // 
            // lbl_NameDescriptionRow
            // 
            this.lbl_NameDescriptionRow.AutoSize = true;
            this.lbl_NameDescriptionRow.Location = new System.Drawing.Point(1121, 94);
            this.lbl_NameDescriptionRow.Name = "lbl_NameDescriptionRow";
            this.lbl_NameDescriptionRow.Size = new System.Drawing.Size(55, 13);
            this.lbl_NameDescriptionRow.TabIndex = 9;
            this.lbl_NameDescriptionRow.Text = "Nome riga";
            // 
            // btn_CancelDescriptionRow
            // 
            this.btn_CancelDescriptionRow.Location = new System.Drawing.Point(1343, 500);
            this.btn_CancelDescriptionRow.Name = "btn_CancelDescriptionRow";
            this.btn_CancelDescriptionRow.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelDescriptionRow.TabIndex = 11;
            this.btn_CancelDescriptionRow.Text = "Cancella";
            this.btn_CancelDescriptionRow.UseVisualStyleBackColor = true;
            // 
            // btn_SaveDescriptionRow
            // 
            this.btn_SaveDescriptionRow.Location = new System.Drawing.Point(1262, 500);
            this.btn_SaveDescriptionRow.Name = "btn_SaveDescriptionRow";
            this.btn_SaveDescriptionRow.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveDescriptionRow.TabIndex = 10;
            this.btn_SaveDescriptionRow.Text = "salva";
            this.btn_SaveDescriptionRow.UseVisualStyleBackColor = true;
            this.btn_SaveDescriptionRow.Click += new System.EventHandler(this.btn_SaveDescriptionRow_Click);
            // 
            // txt_FindTable
            // 
            this.txt_FindTable.Location = new System.Drawing.Point(12, 68);
            this.txt_FindTable.Name = "txt_FindTable";
            this.txt_FindTable.Size = new System.Drawing.Size(295, 20);
            this.txt_FindTable.TabIndex = 12;
            this.txt_FindTable.TextChanged += new System.EventHandler(this.txt_FindTable_TextChanged);
            // 
            // txt_FilterRow
            // 
            this.txt_FilterRow.Location = new System.Drawing.Point(674, 68);
            this.txt_FilterRow.Name = "txt_FilterRow";
            this.txt_FilterRow.Size = new System.Drawing.Size(441, 20);
            this.txt_FilterRow.TabIndex = 13;
            this.txt_FilterRow.TextChanged += new System.EventHandler(this.txt_FilterRow_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filtro tabella";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filtro riga";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 809);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_FilterRow);
            this.Controls.Add(this.txt_FindTable);
            this.Controls.Add(this.btn_CancelDescriptionRow);
            this.Controls.Add(this.btn_SaveDescriptionRow);
            this.Controls.Add(this.lbl_NameDescriptionRow);
            this.Controls.Add(this.rtb_DescriptionRow);
            this.Controls.Add(this.btn_CancelDescriptionTableName);
            this.Controls.Add(this.btn_SaveTableNameDescription);
            this.Controls.Add(this.Dgv_TableName);
            this.Controls.Add(this.Lbl_TableName);
            this.Controls.Add(this.Rtb_TableNameDescription);
            this.Controls.Add(this.Dgv_TableRow);
            this.Controls.Add(this.Btn_LoadDb);
            this.Controls.Add(this.Btn_Config);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TableRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Config;
        private System.Windows.Forms.Button Btn_LoadDb;
        private System.Windows.Forms.RichTextBox Rtb_TableNameDescription;
        private System.Windows.Forms.Label Lbl_TableName;
        private System.Windows.Forms.DataGridView Dgv_TableName;
        private System.Windows.Forms.DataGridView Dgv_TableRow;
        private System.Windows.Forms.Button btn_SaveTableNameDescription;
        private System.Windows.Forms.Button btn_CancelDescriptionTableName;
        private System.Windows.Forms.RichTextBox rtb_DescriptionRow;
        private System.Windows.Forms.Label lbl_NameDescriptionRow;
        private System.Windows.Forms.Button btn_CancelDescriptionRow;
        private System.Windows.Forms.Button btn_SaveDescriptionRow;
        private System.Windows.Forms.TextBox txt_FindTable;
        private System.Windows.Forms.TextBox txt_FilterRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

