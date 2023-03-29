namespace Projekt_Koukal
{
    partial class ARoleControlForm
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
            this.lvRoleChanger = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnRoleUprav = new System.Windows.Forms.Button();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvRoleChanger
            // 
            this.lvRoleChanger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvRoleChanger.GridLines = true;
            this.lvRoleChanger.Location = new System.Drawing.Point(12, 12);
            this.lvRoleChanger.Name = "lvRoleChanger";
            this.lvRoleChanger.Size = new System.Drawing.Size(396, 426);
            this.lvRoleChanger.TabIndex = 0;
            this.lvRoleChanger.UseCompatibleStateImageBehavior = false;
            this.lvRoleChanger.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Název";
            this.columnHeader2.Width = 100;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(426, 12);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteRole.TabIndex = 1;
            this.btnDeleteRole.Text = "SMAŽ";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnRoleUprav
            // 
            this.btnRoleUprav.Location = new System.Drawing.Point(426, 68);
            this.btnRoleUprav.Name = "btnRoleUprav";
            this.btnRoleUprav.Size = new System.Drawing.Size(134, 40);
            this.btnRoleUprav.TabIndex = 2;
            this.btnRoleUprav.Text = "UPRAV";
            this.btnRoleUprav.UseVisualStyleBackColor = true;
            this.btnRoleUprav.Click += new System.EventHandler(this.btnRoleUprav_Click);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.Location = new System.Drawing.Point(426, 124);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(134, 40);
            this.btnRoleAdd.TabIndex = 3;
            this.btnRoleAdd.Text = "PŘIDEJ";
            this.btnRoleAdd.UseVisualStyleBackColor = true;
            this.btnRoleAdd.Click += new System.EventHandler(this.btnRoleAdd_Click);
            // 
            // ARoleControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.btnRoleAdd);
            this.Controls.Add(this.btnRoleUprav);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.lvRoleChanger);
            this.Name = "ARoleControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARoleControlForm";
            this.Load += new System.EventHandler(this.ARoleControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvRoleChanger;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnDeleteRole;
        private Button btnRoleUprav;
        private Button btnRoleAdd;
    }
}