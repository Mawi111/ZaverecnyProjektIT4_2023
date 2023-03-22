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
    public partial class AUserControlForm : Form
    {
        SqlRepository sqlRepository;
        public int IdUser { get; set; }
        public AUserControlForm ParentForm { get; set; }
        public AUserControlForm(int idUser, AUserControlForm parent)
        {
            InitializeComponent();
            IdUser = idUser;
            sqlRepository = new SqlRepository();
            ParentForm = parent;
        }
    }
}
