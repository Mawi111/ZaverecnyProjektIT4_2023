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
    public partial class aWorkTypesManager : Form
    {
        List<WorkType> workTypes;
        public aWorkTypesManager()
        {
            InitializeComponent();
            workTypes = SqlRepo.LoadWorkTypes();
            RefreshWoT();
        }

        private void RefreshWoT()
        {
            lvWorkTypes.Items.Clear();

            foreach (var workType in workTypes)
            {
                if (workType.Name.Contains(txtSearch.Text))
                {
                    lvWorkTypes.Items.Add(new ListViewItem(new string[] { workType.IdWorkType.ToString(),workType.Name, workType.Description}));
                }
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshWoT();
        }

        private void lvWorkTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWorkTypes.SelectedItems.Count == 1)
            {
                btnDeleteWoT.Enabled = true;
                btnEditWoT.Enabled = true;
            }
            else
            {
                btnDeleteWoT.Enabled = false;
                btnEditWoT.Enabled = false;
            }
        }

        private void btnDeleteWoT_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lvWorkTypes.SelectedItems[0].Text);
            SqlRepo.DeleteWorkType(id);
            workTypes = SqlRepo.LoadWorkTypes();
            RefreshWoT();
        }

        private void btnAddWoT_Click(object sender, EventArgs e)
        {
            new aWorkTypeAdd().ShowDialog();
            workTypes= SqlRepo.LoadWorkTypes();
            RefreshWoT();
        }

        private void btnEditWoT_Click(object sender, EventArgs e)
        {
            new aWorkTypeEdit(workTypes[lvWorkTypes.SelectedIndices[0]]).ShowDialog();
            workTypes = SqlRepo.LoadWorkTypes();
            RefreshWoT();
        }
    }
}
