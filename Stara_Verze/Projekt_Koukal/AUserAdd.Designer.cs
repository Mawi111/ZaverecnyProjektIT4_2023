﻿namespace Projekt_Koukal
{
    partial class AUserAdd
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
            this.txtAAddUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPsd = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAAddUser
            // 
            this.txtAAddUser.Location = new System.Drawing.Point(67, 65);
            this.txtAAddUser.Name = "txtAAddUser";
            this.txtAAddUser.Size = new System.Drawing.Size(223, 23);
            this.txtAAddUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Už. jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaměstnanec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role";
            // 
            // btnEditOk
            // 
            this.btnEditOk.Location = new System.Drawing.Point(187, 305);
            this.btnEditOk.Name = "btnEditOk";
            this.btnEditOk.Size = new System.Drawing.Size(103, 37);
            this.btnEditOk.TabIndex = 6;
            this.btnEditOk.Text = "OK";
            this.btnEditOk.UseVisualStyleBackColor = true;
            this.btnEditOk.Click += new System.EventHandler(this.btnEditOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heslo";
            // 
            // txtPsd
            // 
            this.txtPsd.Location = new System.Drawing.Point(67, 127);
            this.txtPsd.Name = "txtPsd";
            this.txtPsd.Size = new System.Drawing.Size(223, 23);
            this.txtPsd.TabIndex = 8;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(67, 189);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(223, 23);
            this.txtEmployee.TabIndex = 9;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(67, 251);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(223, 23);
            this.txtRole.TabIndex = 10;
            // 
            // AUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 354);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtPsd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAAddUser);
            this.Name = "AUserAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUserAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAAddUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEditOk;
        private Label label4;
        private TextBox txtPsd;
        private TextBox txtEmployee;
        private TextBox txtRole;
    }
}