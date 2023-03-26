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
    public partial class AdminForm : Form
    {
        public User User { get; set; }
        public Form Form { get; set; }
        
        public AdminForm()
        {
            InitializeComponent();
        }

        public  AdminForm(User user, Form form)
        {
            User = user;
            Form = form;
        }

        private void btnUserMa_Click(object sender, EventArgs e)
        {
            ARoleControl aUserManagement = new AUserManagement();
            aUserManagement.ShowDialog();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Close();
        }

        private void btnRoleA_Click(object sender, EventArgs e)
        {

        }
    }
}
