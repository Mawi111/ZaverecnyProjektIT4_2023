using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaverecny_Projekt_Koukal
{
    public partial class aWorkHoursManager : Form
    {
        List<WorkHours> workHours;
        public aWorkHoursManager()
        {
            InitializeComponent();
            workHours = SqlRepo.LoadWorkHours();
            RefreshWoH();
        }

        private void RefreshWoH()
        {
            lvWorkHours.Items.Clear();

            foreach (var workHour in workHours)
            {
                lvWorkHours.Items.Add(new ListViewItem(new string[] { workHour.IdWorkHour.ToString(), workHour.Employee.ToString(), workHour.Contract.ToString(), workHour.WorkType.ToString(), workHour.Hours.ToString(), workHour.InsertDate.ToString(), workHour.InsertUser.ToString() }));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshWoH();
        }

        private void lvWorkHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWorkHours.SelectedItems.Count == 1)
            {
                btnDeleteWoH.Enabled = true;
                btnEditWoH.Enabled = true;
            }
            else
            {
                btnDeleteWoH.Enabled = false;
                btnEditWoH.Enabled = false;
            }
        }

        private void btnDeleteWoH_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lvWorkHours.SelectedItems[0].Text);
            SqlRepo.DeleteWorkHours(id);
            workHours = SqlRepo.LoadWorkHours();
            RefreshWoH();
        }

        private void btnAddWoH_Click(object sender, EventArgs e)
        {
            new aWorkHoursAdd().Show();
            workHours= SqlRepo.LoadWorkHours();
            RefreshWoH();
        }

        private void btnEditWoH_Click(object sender, EventArgs e)
        {
            new aWorkHoursEdit(workHours[lvWorkHours.SelectedIndices[0]]).Show();
            workHours = SqlRepo.LoadWorkHours();
            RefreshWoH();    
        }
    }
}
