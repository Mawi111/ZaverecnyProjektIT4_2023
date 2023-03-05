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
    public partial class FormLogin : Form
    {
        private User user { get; set; }
        private SqlRepository sqlRepository;
        public FormLogin()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbPassword.Text == " " && txtbUsername.Text == " ")
            {
                MessageBox.Show("Jméno nebo heslo je špatně.");
            }
            else
            {
                user = sqlRepository.GetUser(txtbUsername.Text);
                if (user != null )
                {
                    if (user.CheckPsw(txtbPassword.Text))
                    {
                        Form1 Form1 = new Form1(user);
                        Form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nikdo takový neexistuje");
                    }
                }
                else
                {
                    MessageBox.Show("Jméno nebo heslo je  špatně");
                }
            }
        }
    }
}
