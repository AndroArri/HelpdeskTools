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
            this.Dgv_Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Config
            // 
            this.Btn_Config.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Config.Location = new System.Drawing.Point(803, 514);
            this.Btn_Config.Name = "Btn_Config";
            this.Btn_Config.Size = new System.Drawing.Size(75, 23);
            this.Btn_Config.TabIndex = 0;
            this.Btn_Config.Text = "Impostazioni";
            this.Btn_Config.UseVisualStyleBackColor = true;
            this.Btn_Config.Click += new System.EventHandler(this.Btn_Config_Click);
            // 
            // Btn_LoadDb
            // 
            this.Btn_LoadDb.Location = new System.Drawing.Point(884, 514);
            this.Btn_LoadDb.Name = "Btn_LoadDb";
            this.Btn_LoadDb.Size = new System.Drawing.Size(75, 23);
            this.Btn_LoadDb.TabIndex = 1;
            this.Btn_LoadDb.Text = "Carica DB";
            this.Btn_LoadDb.UseVisualStyleBackColor = true;
            this.Btn_LoadDb.Click += new System.EventHandler(this.Btn_LoadDb_Click);
            // 
            // Dgv_Table
            // 
            this.Dgv_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Table.Location = new System.Drawing.Point(8, 8);
            this.Dgv_Table.Name = "Dgv_Table";
            this.Dgv_Table.Size = new System.Drawing.Size(789, 525);
            this.Dgv_Table.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.Dgv_Table);
            this.Controls.Add(this.Btn_LoadDb);
            this.Controls.Add(this.Btn_Config);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Config;
        private System.Windows.Forms.Button Btn_LoadDb;
        private System.Windows.Forms.DataGridView Dgv_Table;
    }
}

