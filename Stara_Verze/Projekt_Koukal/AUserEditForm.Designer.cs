namespace Projekt_Koukal
{
    partial class AUserEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAEditUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnAUserEditOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uživatleské jméno";
            // 
            // txtAEditUser
            // 
            this.txtAEditUser.Location = new System.Drawing.Point(81, 74);
            this.txtAEditUser.Name = "txtAEditUser";
            this.txtAEditUser.Size = new System.Drawing.Size(190, 23);
            this.txtAEditUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(81, 144);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(190, 23);
            this.cbRole.TabIndex = 3;
            // 
            // btnAUserEditOk
            // 
            this.btnAUserEditOk.Location = new System.Drawing.Point(125, 199);
            this.btnAUserEditOk.Name = "btnAUserEditOk";
            this.btnAUserEditOk.Size = new System.Drawing.Size(94, 44);
            this.btnAUserEditOk.TabIndex = 4;
            this.btnAUserEditOk.Text = "OK";
            this.btnAUserEditOk.UseVisualStyleBackColor = true;
            this.btnAUserEditOk.Click += new System.EventHandler(this.btnAUserEditOk_Click);
            // 
            // AUserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 391);
            this.Controls.Add(this.btnAUserEditOk);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAEditUser);
            this.Controls.Add(this.label1);
            this.Name = "AUserEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUserEditForm";
            this.Load += new System.EventHandler(this.AUserEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAEditUser;
        private Label label2;
        private ComboBox cbRole;
        private Button btnAUserEditOk;
    }
}