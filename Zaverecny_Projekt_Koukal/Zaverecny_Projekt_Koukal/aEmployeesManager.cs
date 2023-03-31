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
using static System.Reflection.Metadata.BlobBuilder;

namespace Zaverecny_Projekt_Koukal
{
    public partial class aEmployeesManager : Form
    {
        List<Employee> employees;
        public aEmployeesManager()
        {
            InitializeComponent();
            employees = SqlRepo.LoadEmployees();
            RefreshEmployees();
        }

        private void RefreshEmployees()
        {
            lvEmployees.Items.Clear();

            foreach (var employee in employees)
            {
                if (employee.Firstname.Contains(txtSearch.Text) || employee.Lastname.Contains(txtSearch.Text))
                {
                    lvEmployees.Items.Add(new ListViewItem(new string[] { employee.IdEmployees.ToString(),employee.Firstname, employee.Lastname, employee.BirthDate.ToString(), employee.Email, employee.Phone.ToString()}));
                }
            }
        }

        private void lvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedItems.Count == 1)
            {
                btnDeleteEm.Enabled = true;
                btnEditEm.Enabled = true;
            }
            else
            {
                btnDeleteEm.Enabled = false;
                btnEditEm.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshEmployees();
        }

        private void btnDeleteEm_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lvEmployees.SelectedItems[0].Text);
            SqlRepo.DeleteEmployee(id);
            employees = SqlRepo.LoadEmployees();
            RefreshEmployees();
        }

        private void btnAddEm_Click(object sender, EventArgs e)
        {
            new aEmployeeAdd().ShowDialog();
            employees = SqlRepo.LoadEmployees();
            RefreshEmployees();
        }

        private void btnEditEm_Click(object sender, EventArgs e)
        {
            new aEditEmployee(employees[lvEmployees.SelectedIndices[0]]).ShowDialog();
            employees = SqlRepo.LoadEmployees();
            RefreshEmployees();
        }
    }
}
