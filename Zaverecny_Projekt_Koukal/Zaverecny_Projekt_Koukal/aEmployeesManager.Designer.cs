namespace Zaverecny_Projekt_Koukal
{
    partial class aEmployeesManager
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
            this.btnAddEm = new System.Windows.Forms.Button();
            this.btnEditEm = new System.Windows.Forms.Button();
            this.btnDeleteEm = new System.Windows.Forms.Button();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Hledat";
            this.txtSearch.Size = new System.Drawing.Size(156, 23);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddEm
            // 
            this.btnAddEm.Location = new System.Drawing.Point(664, 162);
            this.btnAddEm.Name = "btnAddEm";
            this.btnAddEm.Size = new System.Drawing.Size(124, 43);
            this.btnAddEm.TabIndex = 10;
            this.btnAddEm.Text = "PŘIDAT";
            this.btnAddEm.UseVisualStyleBackColor = true;
            this.btnAddEm.Click += new System.EventHandler(this.btnAddEm_Click);
            // 
            // btnEditEm
            // 
            this.btnEditEm.Enabled = false;
            this.btnEditEm.Location = new System.Drawing.Point(664, 102);
            this.btnEditEm.Name = "btnEditEm";
            this.btnEditEm.Size = new System.Drawing.Size(124, 43);
            this.btnEditEm.TabIndex = 9;
            this.btnEditEm.Text = "UPRAVIT";
            this.btnEditEm.UseVisualStyleBackColor = true;
            this.btnEditEm.Click += new System.EventHandler(this.btnEditEm_Click);
            // 
            // btnDeleteEm
            // 
            this.btnDeleteEm.Enabled = false;
            this.btnDeleteEm.Location = new System.Drawing.Point(664, 42);
            this.btnDeleteEm.Name = "btnDeleteEm";
            this.btnDeleteEm.Size = new System.Drawing.Size(124, 43);
            this.btnDeleteEm.TabIndex = 8;
            this.btnDeleteEm.Text = "SMAZAT";
            this.btnDeleteEm.UseVisualStyleBackColor = true;
            this.btnDeleteEm.Click += new System.EventHandler(this.btnDeleteEm_Click);
            // 
            // lvEmployees
            // 
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvEmployees.FullRowSelect = true;
            this.lvEmployees.GridLines = true;
            this.lvEmployees.Location = new System.Drawing.Point(12, 42);
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(628, 396);
            this.lvEmployees.TabIndex = 7;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            this.lvEmployees.SelectedIndexChanged += new System.EventHandler(this.lvEmployees_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pracovní ID";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jméno";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Příjmení";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum narození";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telefon";
            // 
            // aEmployeesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddEm);
            this.Controls.Add(this.btnEditEm);
            this.Controls.Add(this.btnDeleteEm);
            this.Controls.Add(this.lvEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "aEmployeesManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPRÁVA ZAMĚSTNANCŮ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtSearch;
        private Button btnAddEm;
        private Button btnEditEm;
        private Button btnDeleteEm;
        private ListView lvEmployees;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}