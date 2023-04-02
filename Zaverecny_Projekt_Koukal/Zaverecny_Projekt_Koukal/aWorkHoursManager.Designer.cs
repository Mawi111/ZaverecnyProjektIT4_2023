namespace Zaverecny_Projekt_Koukal
{
    partial class aWorkHoursManager
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddWoH = new System.Windows.Forms.Button();
            this.btnEditWoH = new System.Windows.Forms.Button();
            this.btnDeleteWoH = new System.Windows.Forms.Button();
            this.lvWorkHours = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Hledat";
            this.txtSearch.Size = new System.Drawing.Size(156, 23);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddWoH
            // 
            this.btnAddWoH.Location = new System.Drawing.Point(664, 162);
            this.btnAddWoH.Name = "btnAddWoH";
            this.btnAddWoH.Size = new System.Drawing.Size(124, 43);
            this.btnAddWoH.TabIndex = 15;
            this.btnAddWoH.Text = "PŘIDAT";
            this.btnAddWoH.UseVisualStyleBackColor = true;
            this.btnAddWoH.Click += new System.EventHandler(this.btnAddWoH_Click);
            // 
            // btnEditWoH
            // 
            this.btnEditWoH.Enabled = false;
            this.btnEditWoH.Location = new System.Drawing.Point(664, 102);
            this.btnEditWoH.Name = "btnEditWoH";
            this.btnEditWoH.Size = new System.Drawing.Size(124, 43);
            this.btnEditWoH.TabIndex = 14;
            this.btnEditWoH.Text = "UPRAVIT";
            this.btnEditWoH.UseVisualStyleBackColor = true;
            this.btnEditWoH.Click += new System.EventHandler(this.btnEditWoH_Click);
            // 
            // btnDeleteWoH
            // 
            this.btnDeleteWoH.Enabled = false;
            this.btnDeleteWoH.Location = new System.Drawing.Point(664, 42);
            this.btnDeleteWoH.Name = "btnDeleteWoH";
            this.btnDeleteWoH.Size = new System.Drawing.Size(124, 43);
            this.btnDeleteWoH.TabIndex = 13;
            this.btnDeleteWoH.Text = "SMAZAT";
            this.btnDeleteWoH.UseVisualStyleBackColor = true;
            this.btnDeleteWoH.Click += new System.EventHandler(this.btnDeleteWoH_Click);
            // 
            // lvWorkHours
            // 
            this.lvWorkHours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvWorkHours.FullRowSelect = true;
            this.lvWorkHours.GridLines = true;
            this.lvWorkHours.Location = new System.Drawing.Point(12, 42);
            this.lvWorkHours.Name = "lvWorkHours";
            this.lvWorkHours.Size = new System.Drawing.Size(628, 396);
            this.lvWorkHours.TabIndex = 12;
            this.lvWorkHours.UseCompatibleStateImageBehavior = false;
            this.lvWorkHours.View = System.Windows.Forms.View.Details;
            this.lvWorkHours.SelectedIndexChanged += new System.EventHandler(this.lvWorkHours_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Odp. hodin";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Zaměstnance";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID Kontraktu";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID Práce ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Odp. hodiny";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Datum";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID Uživatele";
            this.columnHeader7.Width = 75;
            // 
            // aWorkHoursManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddWoH);
            this.Controls.Add(this.btnEditWoH);
            this.Controls.Add(this.btnDeleteWoH);
            this.Controls.Add(this.lvWorkHours);
            this.MaximizeBox = false;
            this.Name = "aWorkHoursManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPRÁVA ODP. HODIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSearch;
        private Button btnAddWoH;
        private Button btnEditWoH;
        private Button btnDeleteWoH;
        private ListView lvWorkHours;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}