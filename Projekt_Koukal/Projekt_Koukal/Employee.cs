using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Koukal
{
    internal class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Employee(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

      
    }
}
