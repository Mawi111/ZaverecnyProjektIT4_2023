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

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            aEmployeesManager aEmployeesManager = new aEmployeesManager();
            aEmployeesManager.Show();
        }

        private void btnAContracts_Click(object sender, EventArgs e)
        {
            aContractsManager aContractsManager = new aContractsManager();
            aContractsManager.Show();
        }

        private void btnWorkTypes_Click(object sender, EventArgs e)
        {
            aWorkTypesManager aWorkTypesManager = new aWorkTypesManager();
            aWorkTypesManager.Show();
        }

        private void btnWohManager_Click(object sender, EventArgs e)
        {
            aWorkHoursManager aWorkHoursManager = new aWorkHoursManager();
            aWorkHoursManager.Show();
        }
    }
}
