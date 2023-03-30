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
            txtIdUser.Text = user.IdUser.ToString();
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
            txtRole.Text = user.Role.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlRepo.EditUser(User.IdUser, txtUsername.Text, txtPassword.Text, User.Role);
            Close();
        }
    }
}
