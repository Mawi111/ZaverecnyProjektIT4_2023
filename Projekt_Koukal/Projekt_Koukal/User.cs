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
        public int Id { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Password {get; set;}
        public byte[] PswSalt { get; set; }
        public int IdEmployee { get; set; }
        //public byte[] PswHash { get; set; }

        public User(string username, string password ,byte[] pswHash, byte[] pswSalt)
        {
            Username = username;
            Password = password;
            PswSalt = pswSalt;
            //PswHash = pswHash;
        }
        public User(int id, string username, int idEmployee, int role)
        {
            IdEmployee = idEmployee;
            Username = username;
            Id = id;
            Role = role;
        }
        public void ResetPwd()
        {
            using (var hmac = new HMACSHA512())
            {
                PswSalt = hmac.Key;
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes("Heslo"));
            }
        }
        public bool VerifyPwd(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PswSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(Password);
        }
    }
}
