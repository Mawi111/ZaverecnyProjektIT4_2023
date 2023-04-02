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
    public partial class aWorkHoursAdd : Form
    {
        public aWorkHoursAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlRepo.AddWorkHours(Convert.ToInt32(txtEmployee.Text), Convert.ToInt32(txtContract.Text), Convert.ToInt32(txtWorkType.Text), Convert.ToInt32(txtHours.Text), dtDate.Value, Convert.ToInt32(txtUser.Text));
            Close();
        }
    }
}
