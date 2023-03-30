using System;
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
    public partial class aUserAdd : Form
    {
        public aUserAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlRepo.AddUser(txtUsername.Text, txtPassword.Text, Convert.ToInt32(txtRole.Text), Convert.ToInt32(txtIdEmployee.Text));
            Close();
        }
    }
}
