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
    public partial class aContractsManager : Form
    {
        List<Contract> contracts= new List<Contract>();
        public aContractsManager()
        {
            InitializeComponent();
            contracts = SqlRepo.LoadContracts();
            RefreshContracts();
        }

        private void RefreshContracts()
        {
            lvContracts.Items.Clear();

            foreach (var contract in contracts)
            {
                if (contract.Customer.Contains(txtSearch.Text))
                {
                    lvContracts.Items.Add(new ListViewItem(new string[] { contract.IdContract.ToString(), contract.Customer.ToString(), contract.Description.ToString() })); 
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshContracts();
        }
    }
}
