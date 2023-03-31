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
    public partial class aEmployeeAdd : Form
    {
        public aEmployeeAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlRepo.AddEmployee(txtFirstname.Text,txtLastname.Text,dtmBirthDate.Value, txtEmail.Text, Convert.ToInt32(txtPhone.Text));
            Close();
        }
    }
}
