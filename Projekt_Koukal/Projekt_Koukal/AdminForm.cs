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
        public Form parent { get; set; }
        
        public AdminForm()
        {
            InitializeComponent();
        }

        public  AdminForm(User user, Form parent)
        {
            User = user;
            Parent = parent;
        }

        private void btnUserMa_Click(object sender, EventArgs e)
        {
            AUserManagement aUserManagement = new AUserManagement();
            aUserManagement.ShowDialog();
        }

        private void btnRoleA_Click(object sender, EventArgs e)
        {
            AUserManagement aRoleControl = new AUserManagement(); 
            aRoleControl.ShowDialog();
        }

        private void bntEmployees_Click(object sender, EventArgs e)
        {
            AUserManagement aRoleControl = new AUserManagement();
            aRoleControl.ShowDialog();  
        }
    }
}
