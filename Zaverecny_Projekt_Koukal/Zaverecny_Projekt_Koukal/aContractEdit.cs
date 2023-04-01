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
    public partial class aContractEdit : Form
    {
        public Contract Contract { get; set; }
        public aContractEdit(Contract contract)
        {
            InitializeComponent();
            Contract = contract;

            txtCustomer.Text = contract.Customer;
            txtDescription.Text = contract.Description;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlRepo.EditContract(Contract.IdContract, txtCustomer.Text, txtDescription.Text);
            Close();
        }
    }
}
