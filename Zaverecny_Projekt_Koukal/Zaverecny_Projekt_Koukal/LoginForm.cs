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

            if (txtUserName.Text == "" && txtUserPsd.Text == "")
            {
                MessageBox.Show("Jeden nebo druhý údaj není vyplněn, puso");
            }
            else 
            {
                var user = sqlRepo.GetUser(txtUserName.Text);
                if (user != null) 
                {
                    if (user.Password == txtUserPsd.Text)
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
                        MessageBox.Show("Chybné heslo, miláčku");
                    }
                }
                else 
                {
                    MessageBox.Show("Něco ti chybí, zlato");
                }
            }
        }
    }
}
