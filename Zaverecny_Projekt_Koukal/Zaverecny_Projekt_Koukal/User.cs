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
        public int Role { get; set; }
        public int IdEmployee { get; set; }

        public User(string username, int role) // kostruktor pro GetUser v SqlRepo
        {
            Username = username;
            Role = role;
            
        }

        public User(int idUser, string username, int role, int idEmployee) // kostruktor pro LoadUsers v SqlRepo
        {
            IdUser = idUser;
            Username = username;
            Role = role;
            IdEmployee = idEmployee;
        }

        public User(int idUser,string username, int role) // kostruktor pro EditUser v SqlRepo
        {
            IdUser = idUser;
            Username = username;
            Role = role;
        }




    }
}
