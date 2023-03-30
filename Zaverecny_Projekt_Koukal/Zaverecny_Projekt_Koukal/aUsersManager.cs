using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Zaverecny_Projekt_Koukal
{
    public partial class aUsersManager : Form
    {
        List<User> users;
        //SqlRepo sqlRepo;
        public aUsersManager()
        {
            InitializeComponent();
            users = SqlRepo.LoadUsers();
            RefreshUsers();
        }

        private void RefreshUsers()
        {
            lvUsers.Items.Clear();

            foreach (var user in users)
            {
                if (user.Username.Contains(txtSearch.Text) || user.Password.Contains(txtSearch.Text))
                {
                    lvUsers.Items.Add(new ListViewItem(new string[] { user.IdUser.ToString(), user.Username, user.Password, user.Role.ToString(), user.IdEmployee.ToString()}));
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshUsers();  
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count ==1)
            {
                btnDeleteUser.Enabled = true;
                btnEditUser.Enabled = true;
            }
            else
            {
                btnDeleteUser.Enabled = false;
                btnEditUser.Enabled = false;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lvUsers.SelectedItems[0].Text);
            SqlRepo.DeleteUser(id);
            users = SqlRepo.LoadUsers();
            RefreshUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new aUserAdd().ShowDialog();
            users = SqlRepo.LoadUsers();
            RefreshUsers();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            new aUserEdit(users[lvUsers.SelectedIndices[0]]).ShowDialog();
            users = SqlRepo.LoadUsers();
            RefreshUsers();
        }
    }
}
