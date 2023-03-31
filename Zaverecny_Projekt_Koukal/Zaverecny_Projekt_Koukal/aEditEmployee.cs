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
    public partial class aEditEmployee : Form
    {
        public Employee Employee { get; set; }
        public aEditEmployee(Employee employee)
        {
            InitializeComponent();
            Employee = employee;

            txtFirstname.Text = employee.Firstname;
            txtLastname.Text = employee.Lastname;
            dtmBirthDate.Value = employee.BirthDate;
            txtEmail.Text = employee.Email;
            txtPhone.Text = employee.Phone.ToString();    

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlRepo.EditEmployee(Employee.IdEmployees, txtFirstname.Text, txtLastname.Text, dtmBirthDate.Value,txtEmail.Text, Convert.ToInt32(txtPhone.Text));
            Close();
        }
    }
}
