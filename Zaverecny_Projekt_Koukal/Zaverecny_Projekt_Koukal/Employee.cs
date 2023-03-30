using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_Projekt_Koukal
{
    public class Employee
    {
        public int IdEmployees { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public Employee(int idEmployees, string firstname, string lastname, DateTime birthDate, string email, int phone)
        {
            IdEmployees = idEmployees;
            Firstname = firstname;
            Lastname = lastname;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
        }
    }
}
