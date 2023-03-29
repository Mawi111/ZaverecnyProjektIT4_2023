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
        public AUserManagement aUserManagement { get; set; }
        public AUserAdd(AUserManagement parent)
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
            aUserManagement = parent;
        }

        //private void AUserAdd_Load(object sender, EventArgs e)
        //{
        //    txtEmployee.Clear();
        //    var employees = sqlRepository.GetEmployees();
        //    foreach (var employee in employees)
        //    {
        //        if (!sqlRepository.IsUsered(employee.IdEmployee))
        //        {
        //            txtEmployee.Add(employee.Firstname + " " + employee.Lastname + " - " + employee.IdEmployee);
        //        }

        //    }
        //    txtEmployee.Clear();
        //    var roles = sqlRepository.GetRoles();
        //    foreach (var role in roles)
        //    {
        //        txtRole.Add(role.Rolename);
        //    }
        //}


        private void btnEditOk_Click(object sender, EventArgs e)
        {
            if (txtAAddUser.Text != null && txtEmployee.Text != null && txtEmployee.Text != null)
            {
                var idEmployee = txtEmployee.Text.Split('-');
                //var user = new User(Convert.ToInt32(txtAAddUser.Text));

                var role = sqlRepository.GetRole(txtEmployee.Text);
                sqlRepository.AddUser(txtAAddUser.Text, txtPsd.Text, Convert.ToInt32(txtEmployee.Text), Convert.ToInt32(txtRole.Text));
                
                Close();
                MessageBox.Show("Uživatel přidán brouku!");
            }
            else
            {
                MessageBox.Show("Musíte vyplnit všechna pole!");
            }
        }
    }
}
