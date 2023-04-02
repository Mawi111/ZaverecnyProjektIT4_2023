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
    public partial class UserForm : Form
    {
        List<Contract> contracts;
        List<User> users;
        public UserForm()
        {
            InitializeComponent();
            contracts = SqlRepo.LoadContracts();
            RefreshUC();
        }

        private void RefreshUC()
        {
            lvUContracts.Items.Clear();

            foreach (var contract in contracts)
            {
                if (contract.Customer.Contains(txtSearch.Text))
                {
                    lvUContracts.Items.Add(new ListViewItem(new string[] { contract.IdContract.ToString(), contract.Customer, contract.Description }));
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshUC();
        }
    }
}
