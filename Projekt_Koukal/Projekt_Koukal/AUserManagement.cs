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
            SqlRepository sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            lvAUManager.Items.Clear();
            var users = sqlRepository.GetUsers();
            foreach (var user in users)
            {
                var employee = sqlRepository.GetEmployee(user.IdEmployee);
                var role = sqlRepository.GetRole(user.Role);
                lvAUManager.Items.Add(new ListViewItem(new string[] { employee.FirstName + " " + employee.LastName, user.UserName, user.Id.ToString(), role.Name.ToString() }));
            }
        }

        private void AUserManagement_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminUserAdd adminUserAdd = new AdminUserAdd();
            adminUserAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(lvAUManager.SelectedItems[0].SubItems[2].Text);
            AUserManagement aUserManagement = new /*User edit*/(id, this);
            aUserManagement.ShowDialog(); 
        }
    }
}
