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
    public partial class aWorkTypeEdit : Form
    {
        public WorkType WorkType { get; set; }
        public aWorkTypeEdit(WorkType workType)
        {
            InitializeComponent();
            WorkType = workType;

            txtName.Text = workType.Name;
            txtDescription.Text = workType.Description;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlRepo.EditWorkType(WorkType.IdWorkType, txtName.Text, txtDescription.Text);
            Close();
        }
    }
}
