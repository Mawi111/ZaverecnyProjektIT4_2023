namespace Projekt_Koukal
{
    partial class AUserManagement
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
            this.lvAUManager = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.IdEmployee = new System.Windows.Forms.ColumnHeader();
            this.EmployeeName = new System.Windows.Forms.ColumnHeader();
            this.UserName = new System.Windows.Forms.ColumnHeader();
            this.Role = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvAUManager
            // 
            this.lvAUManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdEmployee,
            this.EmployeeName,
            this.UserName,
            this.Role});
            this.lvAUManager.GridLines = true;
            this.lvAUManager.Location = new System.Drawing.Point(12, 12);
            this.lvAUManager.Name = "lvAUManager";
            this.lvAUManager.Size = new System.Drawing.Size(644, 426);
            this.lvAUManager.TabIndex = 0;
            this.lvAUManager.UseCompatibleStateImageBehavior = false;
            this.lvAUManager.View = System.Windows.Forms.View.Details;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(662, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 46);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "SMAŽ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(662, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 46);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "PŘIDEJ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(662, 116);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 46);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "UPRAVIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // IdEmployee
            // 
            this.IdEmployee.Text = "ID";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Zaměstnanec/kyně";
            this.EmployeeName.Width = 120;
            // 
            // UserName
            // 
            this.UserName.Text = "Uživatel";
            this.UserName.Width = 100;
            // 
            // Role
            // 
            this.Role.Text = "Role";
            // 
            // AUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvAUManager);
            this.Name = "AUserManagement";
            this.Text = "AUserManagement";
            this.Load += new System.EventHandler(this.AUserManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvAUManager;
        private ColumnHeader IdEmployee;
        private ColumnHeader EmployeeName;
        private ColumnHeader UserName;
        private ColumnHeader Role;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
    }
}