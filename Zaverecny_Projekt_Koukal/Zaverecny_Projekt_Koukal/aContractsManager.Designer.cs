namespace Zaverecny_Projekt_Koukal
{
    partial class aContractsManager
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
            this.lvContracts = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
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
            // btnAddEm
            // 
            this.btnAddEm.Location = new System.Drawing.Point(664, 162);
            this.btnAddEm.Name = "btnAddEm";
            this.btnAddEm.Size = new System.Drawing.Size(124, 43);
            this.btnAddEm.TabIndex = 15;
            this.btnAddEm.Text = "PŘIDAT";
            this.btnAddEm.UseVisualStyleBackColor = true;
            // 
            // btnEditEm
            // 
            this.btnEditEm.Enabled = false;
            this.btnEditEm.Location = new System.Drawing.Point(664, 102);
            this.btnEditEm.Name = "btnEditEm";
            this.btnEditEm.Size = new System.Drawing.Size(124, 43);
            this.btnEditEm.TabIndex = 14;
            this.btnEditEm.Text = "UPRAVIT";
            this.btnEditEm.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEm
            // 
            this.btnDeleteEm.Enabled = false;
            this.btnDeleteEm.Location = new System.Drawing.Point(664, 42);
            this.btnDeleteEm.Name = "btnDeleteEm";
            this.btnDeleteEm.Size = new System.Drawing.Size(124, 43);
            this.btnDeleteEm.TabIndex = 13;
            this.btnDeleteEm.Text = "SMAZAT";
            this.btnDeleteEm.UseVisualStyleBackColor = true;
            // 
            // lvContracts
            // 
            this.lvContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvContracts.FullRowSelect = true;
            this.lvContracts.GridLines = true;
            this.lvContracts.Location = new System.Drawing.Point(12, 42);
            this.lvContracts.Name = "lvContracts";
            this.lvContracts.Size = new System.Drawing.Size(628, 396);
            this.lvContracts.TabIndex = 12;
            this.lvContracts.UseCompatibleStateImageBehavior = false;
            this.lvContracts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Kontraktu";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zákazník";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Popis";
            this.columnHeader3.Width = 200;
            // 
            // aContractsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddEm);
            this.Controls.Add(this.btnEditEm);
            this.Controls.Add(this.btnDeleteEm);
            this.Controls.Add(this.lvContracts);
            this.Name = "aContractsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aContractsManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSearch;
        private Button btnAddEm;
        private Button btnEditEm;
        private Button btnDeleteEm;
        private ListView lvContracts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}