namespace Projekt_Koukal
{
    partial class MainAdminForm2
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
            this.btnUsMaAdmin = new System.Windows.Forms.Button();
            this.btnMaEmAdmin = new System.Windows.Forms.Button();
            this.btnMaWoAdmin = new System.Windows.Forms.Button();
            this.btnMaRoAdmin = new System.Windows.Forms.Button();
            this.btnMaCoAdmin = new System.Windows.Forms.Button();
            this.btnWoHoAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsMaAdmin
            // 
            this.btnUsMaAdmin.Location = new System.Drawing.Point(215, 108);
            this.btnUsMaAdmin.Name = "btnUsMaAdmin";
            this.btnUsMaAdmin.Size = new System.Drawing.Size(133, 50);
            this.btnUsMaAdmin.TabIndex = 0;
            this.btnUsMaAdmin.Text = "SPRAVÁ UŽIVATELŮ";
            this.btnUsMaAdmin.UseVisualStyleBackColor = true;
            // 
            // btnMaEmAdmin
            // 
            this.btnMaEmAdmin.Location = new System.Drawing.Point(215, 194);
            this.btnMaEmAdmin.Name = "btnMaEmAdmin";
            this.btnMaEmAdmin.Size = new System.Drawing.Size(133, 50);
            this.btnMaEmAdmin.TabIndex = 1;
            this.btnMaEmAdmin.Text = "SPRÁVA ZAMĚSTNANCŮ";
            this.btnMaEmAdmin.UseVisualStyleBackColor = true;
            // 
            // btnMaWoAdmin
            // 
            this.btnMaWoAdmin.Location = new System.Drawing.Point(215, 280);
            this.btnMaWoAdmin.Name = "btnMaWoAdmin";
            this.btnMaWoAdmin.Size = new System.Drawing.Size(133, 50);
            this.btnMaWoAdmin.TabIndex = 2;
            this.btnMaWoAdmin.Text = "SPRÁVA PRACÍ";
            this.btnMaWoAdmin.UseVisualStyleBackColor = true;
            // 
            // btnMaRoAdmin
            // 
            this.btnMaRoAdmin.Location = new System.Drawing.Point(446, 108);
            this.btnMaRoAdmin.Name = "btnMaRoAdmin";
            this.btnMaRoAdmin.Size = new System.Drawing.Size(133, 50);
            this.btnMaRoAdmin.TabIndex = 3;
            this.btnMaRoAdmin.Text = "SPRÁVA ROLÍ";
            this.btnMaRoAdmin.UseVisualStyleBackColor = true;
            // 
            // btnMaCoAdmin
            // 
            this.btnMaCoAdmin.Location = new System.Drawing.Point(446, 194);
            this.btnMaCoAdmin.Name = "btnMaCoAdmin";
            this.btnMaCoAdmin.Size = new System.Drawing.Size(133, 50);
            this.btnMaCoAdmin.TabIndex = 4;
            this.btnMaCoAdmin.Text = "SPRÁVA KONTRAKTŮ";
            this.btnMaCoAdmin.UseVisualStyleBackColor = true;
            // 
            // btnWoHoAdmin
            // 
            this.btnWoHoAdmin.Location = new System.Drawing.Point(446, 280);
            this.btnWoHoAdmin.Name = "btnWoHoAdmin";
            this.btnWoHoAdmin.Size = new System.Drawing.Size(133, 50);
            this.btnWoHoAdmin.TabIndex = 5;
            this.btnWoHoAdmin.Text = "ODPRACOVANÉ HODINY";
            this.btnWoHoAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(689, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // MainAdminForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWoHoAdmin);
            this.Controls.Add(this.btnMaCoAdmin);
            this.Controls.Add(this.btnMaRoAdmin);
            this.Controls.Add(this.btnMaWoAdmin);
            this.Controls.Add(this.btnMaEmAdmin);
            this.Controls.Add(this.btnUsMaAdmin);
            this.Name = "MainAdminForm2";
            this.Text = "MainAdminForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUsMaAdmin;
        private Button btnMaEmAdmin;
        private Button btnMaWoAdmin;
        private Button btnMaRoAdmin;
        private Button btnMaCoAdmin;
        private Button btnWoHoAdmin;
        private Label label1;
    }
}