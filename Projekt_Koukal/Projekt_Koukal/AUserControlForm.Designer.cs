namespace Projekt_Koukal
{
    partial class AUserControlForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnResPsw = new System.Windows.Forms.Button();
            this.btnAUsConOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Už. jméno";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // btnResPsw
            // 
            this.btnResPsw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResPsw.Location = new System.Drawing.Point(84, 131);
            this.btnResPsw.Name = "btnResPsw";
            this.btnResPsw.Size = new System.Drawing.Size(75, 49);
            this.btnResPsw.TabIndex = 4;
            this.btnResPsw.Text = "Restart Hesla";
            this.btnResPsw.UseVisualStyleBackColor = true;
            // 
            // btnAUsConOK
            // 
            this.btnAUsConOK.Location = new System.Drawing.Point(172, 131);
            this.btnAUsConOK.Name = "btnAUsConOK";
            this.btnAUsConOK.Size = new System.Drawing.Size(75, 49);
            this.btnAUsConOK.TabIndex = 5;
            this.btnAUsConOK.Text = "OK";
            this.btnAUsConOK.UseVisualStyleBackColor = true;
            // 
            // AUserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 210);
            this.Controls.Add(this.btnAUsConOK);
            this.Controls.Add(this.btnResPsw);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AUserControlForm";
            this.Text = "AUserControlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Button btnResPsw;
        private Button btnAUsConOK;
    }
}