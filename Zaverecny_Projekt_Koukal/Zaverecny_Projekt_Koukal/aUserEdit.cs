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
    public partial class aUserEdit : Form
    {
        public User User { get; set; }
        public aUserEdit(User user)
        {
            InitializeComponent();
            User = user;
            
            txtUsername.Text = user.Username;
            txtRole.Text = user.Role.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtRole.Text) <= 0  || Convert.ToInt32(txtRole.Text) > 2)
            {
                MessageBox.Show("Role jsou pouze: 1 pro admina a 2 pro usera");
                Close();
            }
            else
            {
                SqlRepo.EditUser(User.IdUser, txtUsername.Text, txtPassword.Text, Convert.ToInt32(txtRole.Text));
                Close();
            }    
        }
    }
}
