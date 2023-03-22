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
    public partial class LoginForm : Form
    {
        private User user { get; set; }
        private SqlRepository sqlRepository;
        public LoginForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbUsername.Text != "" && txtbPassword.Text != "")
            {
                User user = sqlRepository.GetUser(txtbUsername.Text);
                if (user != null)
                {
                    if (user.VerifyPwd(txtbPassword.Text))
                    {
                        MainAdminForm2 form1 = new MainAdminForm2(user, this);
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Heslo není správné!");
                    }
                }
                else
                {
                    MessageBox.Show("Uživatel neexistuje!");
                }
            }
            else
            {
                MessageBox.Show("Nevyplnil jste heslo nebo uživatelské jméno!");
            }

        }
    }
}
