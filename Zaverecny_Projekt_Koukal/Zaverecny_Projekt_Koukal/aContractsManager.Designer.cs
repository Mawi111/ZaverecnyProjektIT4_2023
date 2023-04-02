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
            this.btnAddCo = new System.Windows.Forms.Button();
            this.btnEditCo = new System.Windows.Forms.Button();
            this.btnDeleteCo = new System.Windows.Forms.Button();
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
            // btnAddCo
            // 
            this.btnAddCo.Location = new System.Drawing.Point(664, 162);
            this.btnAddCo.Name = "btnAddCo";
            this.btnAddCo.Size = new System.Drawing.Size(124, 43);
            this.btnAddCo.TabIndex = 15;
            this.btnAddCo.Text = "PŘIDAT";
            this.btnAddCo.UseVisualStyleBackColor = true;
            this.btnAddCo.Click += new System.EventHandler(this.btnAddCo_Click);
            // 
            // btnEditCo
            // 
            this.btnEditCo.Enabled = false;
            this.btnEditCo.Location = new System.Drawing.Point(664, 102);
            this.btnEditCo.Name = "btnEditCo";
            this.btnEditCo.Size = new System.Drawing.Size(124, 43);
            this.btnEditCo.TabIndex = 14;
            this.btnEditCo.Text = "UPRAVIT";
            this.btnEditCo.UseVisualStyleBackColor = true;
            this.btnEditCo.Click += new System.EventHandler(this.btnEditCo_Click);
            // 
            // btnDeleteCo
            // 
            this.btnDeleteCo.Enabled = false;
            this.btnDeleteCo.Location = new System.Drawing.Point(664, 42);
            this.btnDeleteCo.Name = "btnDeleteCo";
            this.btnDeleteCo.Size = new System.Drawing.Size(124, 43);
            this.btnDeleteCo.TabIndex = 13;
            this.btnDeleteCo.Text = "SMAZAT";
            this.btnDeleteCo.UseVisualStyleBackColor = true;
            this.btnDeleteCo.Click += new System.EventHandler(this.btnDeleteCo_Click);
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
            this.lvContracts.SelectedIndexChanged += new System.EventHandler(this.lvContracts_SelectedIndexChanged);
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
            this.Controls.Add(this.btnAddCo);
            this.Controls.Add(this.btnEditCo);
            this.Controls.Add(this.btnDeleteCo);
            this.Controls.Add(this.lvContracts);
            this.MaximizeBox = false;
            this.Name = "aContractsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPRÁVA KONTRAKTU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSearch;
        private Button btnAddCo;
        private Button btnEditCo;
        private Button btnDeleteCo;
        private ListView lvContracts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}