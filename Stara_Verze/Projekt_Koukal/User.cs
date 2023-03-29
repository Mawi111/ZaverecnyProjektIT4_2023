using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projekt_Koukal
{
    public class User
    {
        public int IdUser { get; set; }
        public int Role { get; set; }
        public string Username { get; set; }
        public string Password {get; set;}
        //public string[] PswSalt { get; set; }
        //public string[] PswHash { get; set; }
        public int IdEmployee { get; set; }
        

        public User(string username, string password /*,byte[] pswHash, byte[] pswSalt*/)
        {
            Username = username;
            Password = password;
            //PswSalt = pswSalt;
            //PswHash = pswHash;
        }
        public User(int id, string username, int idEmployee, int role)
        {
            IdEmployee = idEmployee;
            Username = username;
            IdUser = id;
            Role = role;
        }

        public User(int idUser, int role, string username, string password/*, byte[] pswSalt*/) : this(idUser)
        {
            Role = role;
            Username = username;
            Password = password;
            //PswSalt = pswSalt;
        }

        public User(int idUser)
        {
            IdUser = idUser;
        }

        //public bool VerifyPwd(string text)
        //{
        //    byte[] hash;
        //    using (var hmac = new HMACSHA512(PswSalt))
        //    {
        //        hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
        //    }
        //    return hash.SequenceEqual(Password);
        //}

        //private void HashPassword(string password)
        //{
        //    using (var hmac = new HMACSHA512())
        //    {
        //        PswSalt = hmac.Key;
        //        Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        //    }
        //}

        //public void ChangePassword(string password)
        //{
        //    HashPassword(password);
        //}
    }
}
