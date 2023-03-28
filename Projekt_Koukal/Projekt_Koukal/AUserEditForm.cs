using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Projekt_Koukal
{
    public partial class AUserEditForm : Form
    {
        SqlRepository sqlRepository;
        public int IdUser { get; set; }
        public AdminForm ParentForm { get; set; }

        public AUserEditForm()
        {
            InitializeComponent();
            IdUser = IdUser;
            sqlRepository = new SqlRepository();
            ParentForm = parent;
        }

        private void btnAUserEditOk_Click(object sender, EventArgs e)
        {
            if (cbRole.Text != "" && txtAEditUser.Text != "")
            {
                var role = sqlRepository.GetRole(cbRole.Text);
                sqlRepository.UpdateUser(txtAEditUser.Text, role.Id, IdUser);
                ParentForm.LoadData();
                this.Close();
                MessageBox.Show("Uživatel úspěšně změněn");
            }
            else
            {
                MessageBox.Show("Něco se pokazilo");
            }
        }

        private void AUserEditForm_Load(object sender, EventArgs e)
        {
            var user = sqlRepository.GetUser(IdUser);
            txtAEditUser.Text = user.Username;
            var role = sqlRepository.GetRole(user.Role);
            cbRole.Text = role.Name;
            var roles = sqlRepository.GetRoles();
            foreach (var rol in roles)
            {
                cbRole.Items.Add(rol.Name);
            }
        }
    }
}
