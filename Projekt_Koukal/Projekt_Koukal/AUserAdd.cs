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
        public AUserAdd(AUserManagement form);
        public AUserAdd()
        {
            InitializeComponent();
        }
    }
}
