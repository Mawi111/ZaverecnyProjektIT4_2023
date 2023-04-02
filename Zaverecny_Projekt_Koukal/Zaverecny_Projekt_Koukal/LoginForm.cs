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
    public partial class LoginForm : Form
    {
        SqlRepo sqlRepo;
        public LoginForm()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {

           
            var user = SqlRepo.CheckLogin(txtUserName.Text, txtUserPsd.Text);
            if (user != null) 
            {
                if (user.Role == 1)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                }
                else if (user.Role == 2) 
                {
                    UserForm userForm = new UserForm();
                    userForm.ShowDialog();
                }
            }
            else 
            {
                MessageBox.Show("Jeden nebo druhý údaj je špatně, broučku");
            }
            
        }
    }
}
