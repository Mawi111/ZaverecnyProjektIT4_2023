using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_Projekt_Koukal
{
    public class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public int IdEmployee { get; set; }

        public User(string username, string password, int role)
        {
            Username = username;
            Password = password;
            Role = role;
        }


    }
}
