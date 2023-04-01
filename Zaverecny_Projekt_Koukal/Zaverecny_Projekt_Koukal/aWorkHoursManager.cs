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
                lvWorkHours.Items.Add(new ListViewItem(new string[] { workHour.IdWorkHours.ToString(), workHour.Employee.ToString(), workHour.Contract.ToString(), workHour.WorkType.ToString(), workHour.Hours.ToString(), workHour.InsertDate.ToString(), workHour.InsertUser.ToString() }));
            }
        }
    }
}
