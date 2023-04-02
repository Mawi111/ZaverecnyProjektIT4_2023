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
    public partial class aWorkHoursEdit : Form
    {
        public WorkHours WorkHours { get; set; }
        public aWorkHoursEdit(WorkHours workHours)
        {
            InitializeComponent();
            WorkHours= workHours;

            txtEmployee.Text = workHours.Employee.ToString(); 
            txtContract.Text = workHours.Contract.ToString(); 
            txtWorkType.Text = workHours.WorkType.ToString(); 
            txtHours.Text = workHours.Hours.ToString(); 
            dtDate.Value = workHours.InsertDate; 
            txtUser.Text = workHours.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlRepo.EditWorkHours(Convert.ToInt32(txtEmployee.Text), Convert.ToInt32(txtContract.Text), Convert.ToInt32(txtWorkType.Text), Convert.ToInt32(txtHours.Text), Convert.ToDateTime(dtDate.Value), Convert.ToInt32(txtUser.Text));
            Close();
        }
    }
}
