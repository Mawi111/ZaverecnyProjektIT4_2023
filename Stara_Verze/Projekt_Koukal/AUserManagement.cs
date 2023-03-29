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
    public partial class AUserManagement : Form
    {
        SqlRepository sqlRepository;

        public AUserManagement()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            lvAUManager.Items.Clear();
            var users = sqlRepository.GetUsers();
            foreach (var user in users)
            {
                var employee = sqlRepository.GetEmployee(user.IdEmployee);
                var role = sqlRepository.GetRole(user.Role);
                lvAUManager.Items.Add(new ListViewItem(new string[] { employee.Firstname + " " + employee.Lastname, user.Username, user.IdUser.ToString(), role.Rolename.ToString() }));
            }
        }

        private void AUserManagement_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlRepository.DeleteUser(Convert.ToInt32(lvAUManager.SelectedItems[0].SubItems[2].Text));
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AUserAdd aUserAdd = new AUserAdd(this);
            aUserAdd.ShowDialog(); 

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(lvAUManager.SelectedItems[0].SubItems[2].Text);
            AUserEditForm aUserEditForm = new AUserEditForm(id, this);
            aUserEditForm.ShowDialog();
        }
    }
}
