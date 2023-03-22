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
    public partial class MainAdminForm2 : Form
    {
        public User User { get; set; }
        public Form Parent { get; set; }
        public MainAdminForm2(User user, Form form)
        {
            InitializeComponent();
            User = user;
            Parent = form;
        }
    }
}
