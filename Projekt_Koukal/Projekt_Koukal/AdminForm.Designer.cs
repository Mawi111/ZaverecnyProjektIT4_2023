namespace Projekt_Koukal
{
    partial class AdminForm
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
            this.btnUserMa = new System.Windows.Forms.Button();
            this.btnRoleA = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUserMa
            // 
            this.btnUserMa.Location = new System.Drawing.Point(205, 88);
            this.btnUserMa.Name = "btnUserMa";
            this.btnUserMa.Size = new System.Drawing.Size(141, 61);
            this.btnUserMa.TabIndex = 0;
            this.btnUserMa.Text = "SPRÁVA UŽIVATELŮ";
            this.btnUserMa.UseVisualStyleBackColor = true;
            this.btnUserMa.Click += new System.EventHandler(this.btnUserMa_Click);
            // 
            // btnRoleA
            // 
            this.btnRoleA.Location = new System.Drawing.Point(205, 194);
            this.btnRoleA.Name = "btnRoleA";
            this.btnRoleA.Size = new System.Drawing.Size(141, 61);
            this.btnRoleA.TabIndex = 1;
            this.btnRoleA.Text = "ROLE";
            this.btnRoleA.UseVisualStyleBackColor = true;
            this.btnRoleA.Click += new System.EventHandler(this.btnRoleA_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(441, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(441, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(441, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 61);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(687, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRoleA);
            this.Controls.Add(this.btnUserMa);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUserMa;
        private Button btnRoleA;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
    }
}