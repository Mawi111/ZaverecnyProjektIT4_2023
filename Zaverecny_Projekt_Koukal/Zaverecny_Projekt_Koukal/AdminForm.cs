﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaverecny_Projekt_Koukal
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnAUsers_Click(object sender, EventArgs e)
        {
            aUsersManager aUsersManager = new aUsersManager();  
            aUsersManager.ShowDialog();
        }
    }
}
