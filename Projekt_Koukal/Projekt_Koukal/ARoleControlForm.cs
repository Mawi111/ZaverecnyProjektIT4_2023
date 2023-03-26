using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Koukal
{
    public partial class ARoleControlForm : Form
    {

        SqlRepository sqlRepository;
        public ARoleControlForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {

        }

        private void btnRoleUprav_Click(object sender, EventArgs e)
        {

        }

        private void btnRoleAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
