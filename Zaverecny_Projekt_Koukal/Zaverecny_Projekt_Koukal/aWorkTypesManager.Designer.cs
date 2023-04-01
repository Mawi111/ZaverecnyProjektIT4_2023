namespace Zaverecny_Projekt_Koukal
{
    partial class aWorkTypesManager
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
            this.btnAddWoT = new System.Windows.Forms.Button();
            this.btnEditWoT = new System.Windows.Forms.Button();
            this.btnDeleteWoT = new System.Windows.Forms.Button();
            this.lvWorkTypes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
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
            // btnAddWoT
            // 
            this.btnAddWoT.Location = new System.Drawing.Point(664, 162);
            this.btnAddWoT.Name = "btnAddWoT";
            this.btnAddWoT.Size = new System.Drawing.Size(124, 43);
            this.btnAddWoT.TabIndex = 15;
            this.btnAddWoT.Text = "PŘIDAT";
            this.btnAddWoT.UseVisualStyleBackColor = true;
            this.btnAddWoT.Click += new System.EventHandler(this.btnAddWoT_Click);
            // 
            // btnEditWoT
            // 
            this.btnEditWoT.Enabled = false;
            this.btnEditWoT.Location = new System.Drawing.Point(664, 102);
            this.btnEditWoT.Name = "btnEditWoT";
            this.btnEditWoT.Size = new System.Drawing.Size(124, 43);
            this.btnEditWoT.TabIndex = 14;
            this.btnEditWoT.Text = "UPRAVIT";
            this.btnEditWoT.UseVisualStyleBackColor = true;
            this.btnEditWoT.Click += new System.EventHandler(this.btnEditWoT_Click);
            // 
            // btnDeleteWoT
            // 
            this.btnDeleteWoT.Enabled = false;
            this.btnDeleteWoT.Location = new System.Drawing.Point(664, 42);
            this.btnDeleteWoT.Name = "btnDeleteWoT";
            this.btnDeleteWoT.Size = new System.Drawing.Size(124, 43);
            this.btnDeleteWoT.TabIndex = 13;
            this.btnDeleteWoT.Text = "SMAZAT";
            this.btnDeleteWoT.UseVisualStyleBackColor = true;
            this.btnDeleteWoT.Click += new System.EventHandler(this.btnDeleteWoT_Click);
            // 
            // lvWorkTypes
            // 
            this.lvWorkTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.lvWorkTypes.FullRowSelect = true;
            this.lvWorkTypes.GridLines = true;
            this.lvWorkTypes.Location = new System.Drawing.Point(12, 42);
            this.lvWorkTypes.Name = "lvWorkTypes";
            this.lvWorkTypes.Size = new System.Drawing.Size(628, 396);
            this.lvWorkTypes.TabIndex = 12;
            this.lvWorkTypes.UseCompatibleStateImageBehavior = false;
            this.lvWorkTypes.View = System.Windows.Forms.View.Details;
            this.lvWorkTypes.SelectedIndexChanged += new System.EventHandler(this.lvWorkTypes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Práce";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Název práce";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Popis práce";
            this.columnHeader5.Width = 450;
            // 
            // aWorkTypesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddWoT);
            this.Controls.Add(this.btnEditWoT);
            this.Controls.Add(this.btnDeleteWoT);
            this.Controls.Add(this.lvWorkTypes);
            this.Name = "aWorkTypesManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aWorkTypesManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSearch;
        private Button btnAddWoT;
        private Button btnEditWoT;
        private Button btnDeleteWoT;
        private ListView lvWorkTypes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader5;
    }
}