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
    public partial class AUserAdd : Form
    {
        SqlRepository sqlRepository;
        public ARoleControl aUserManagement { get; set; }
        public AUserAdd(ARoleControl parent)
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
            aUserManagement = parent;
        }

        private void AUserAdd_Load(object sender, EventArgs e)
        {
            cbEmployee.Items.Clear();
            var employees = sqlRepository.GetEmployee();
            foreach (var employee in employees)
            {
                if (!sqlRepository.IsUsered(employee.Id))
                {
                    cbEmployee.Items.Add(employee.FirstName + " " + employee.LastName + " - " + employee.Id);
                }
            }
            cbRole.Items.Clear();
            var roles = sqlRepository.GetRoles();
            foreach (var role in roles)
            {
                cbRole.Items.Add(role.Name);
            }
        }

        private void btnEditOk_Click(object sender, EventArgs e)
        {
            if (txtAAddUser.Text != null && cbEmployee.Text != null && cbRole.Text != null)
            {
                var idEmployee = cbEmployee.Text.Split('-');
                var user = new User(txtAAddUser.Text);
                var role = sqlRepository.GetRole(cbRole.Text);
                user.ResetPassword();
                sqlRepository.AddUser(user.Username, Convert.ToInt32(idEmployee[1].Trim()), role.Id, user.Password, user.PasswordSalt);
                ParentForm.LoadData();
                Close();
                MessageBox.Show("Uživatel úspěšně přidán!");
            }
            else
            {
                MessageBox.Show("Musíte vyplnit všechna pole!");
            }
        }
    }
}
