using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Koukal
{
    public class Role
    {
        public string Rolename { get; set; }
        public int IdRole { get; set; }
        public Role(string name)
        {
            Rolename = name;
        }

        public Role(int id)
        {
            IdRole = id;
        }

        
    }
}
