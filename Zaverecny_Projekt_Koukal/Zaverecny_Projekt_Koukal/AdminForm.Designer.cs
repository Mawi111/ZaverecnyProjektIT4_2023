namespace Zaverecny_Projekt_Koukal
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
            this.btnAUsers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnAContracts = new System.Windows.Forms.Button();
            this.btnWorkTypes = new System.Windows.Forms.Button();
            this.btnWohManager = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAUsers
            // 
            this.btnAUsers.Location = new System.Drawing.Point(166, 175);
            this.btnAUsers.Name = "btnAUsers";
            this.btnAUsers.Size = new System.Drawing.Size(152, 53);
            this.btnAUsers.TabIndex = 1;
            this.btnAUsers.Text = "UŽIVATELÉ";
            this.btnAUsers.UseVisualStyleBackColor = true;
            this.btnAUsers.Click += new System.EventHandler(this.btnAUsers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(166, 102);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(152, 53);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "ZAMĚSTNANCI";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnAContracts
            // 
            this.btnAContracts.Location = new System.Drawing.Point(166, 248);
            this.btnAContracts.Name = "btnAContracts";
            this.btnAContracts.Size = new System.Drawing.Size(152, 53);
            this.btnAContracts.TabIndex = 2;
            this.btnAContracts.Text = "KONTRAKTY";
            this.btnAContracts.UseVisualStyleBackColor = true;
            this.btnAContracts.Click += new System.EventHandler(this.btnAContracts_Click);
            // 
            // btnWorkTypes
            // 
            this.btnWorkTypes.Location = new System.Drawing.Point(482, 102);
            this.btnWorkTypes.Name = "btnWorkTypes";
            this.btnWorkTypes.Size = new System.Drawing.Size(152, 53);
            this.btnWorkTypes.TabIndex = 3;
            this.btnWorkTypes.Text = "TYPY PRACÍ";
            this.btnWorkTypes.UseVisualStyleBackColor = true;
            this.btnWorkTypes.Click += new System.EventHandler(this.btnWorkTypes_Click);
            // 
            // btnWohManager
            // 
            this.btnWohManager.Location = new System.Drawing.Point(482, 175);
            this.btnWohManager.Name = "btnWohManager";
            this.btnWohManager.Size = new System.Drawing.Size(152, 53);
            this.btnWohManager.TabIndex = 4;
            this.btnWohManager.Text = "ROZPIS PRÁCE";
            this.btnWohManager.UseVisualStyleBackColor = true;
            this.btnWohManager.Click += new System.EventHandler(this.btnWohManager_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(482, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 53);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnWohManager);
            this.Controls.Add(this.btnWorkTypes);
            this.Controls.Add(this.btnAContracts);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnAUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMINISTRÁTOR";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAUsers;
        private Button btnEmployees;
        private Button btnAContracts;
        private Button btnWorkTypes;
        private Button btnWohManager;
        private Button button6;
    }
}