using Microsoft.VisualBasic.ApplicationServices;
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
        List<Contract> contracts;
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
                    lvContracts.Items.Add(new ListViewItem(new string[] { contract.IdContract.ToString(), contract.Customer, contract.Description})); 
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshContracts();
        }

        private void lvContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvContracts.SelectedItems.Count == 1)
            {
                btnDeleteCo.Enabled = true;
                btnEditCo.Enabled = true;
            }
            else
            {
                btnDeleteCo.Enabled = false;
                btnEditCo.Enabled = false;
            }
        }

        private void btnDeleteCo_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lvContracts.SelectedItems[0].Text);
            SqlRepo.DeleteContract(id);
            contracts = SqlRepo.LoadContracts();
            RefreshContracts();
        }

        private void btnAddCo_Click(object sender, EventArgs e)
        {
            new aContractionAdd().ShowDialog();
            contracts= SqlRepo.LoadContracts(); 
            RefreshContracts();
        }

        private void btnEditCo_Click(object sender, EventArgs e)
        {
            new aContractEdit(contracts[lvContracts.SelectedIndices[0]]).ShowDialog();
            contracts= SqlRepo.LoadContracts();
            RefreshContracts(); 
        }
    }
}
