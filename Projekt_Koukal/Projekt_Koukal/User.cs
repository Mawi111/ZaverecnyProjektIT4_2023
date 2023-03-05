using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Projekt_Koukal
{
    public class User
    {
        public string Username { get; set; }
        public string Password {get; set;}
        public byte[] PswSalt { get; set; }
        public byte[] PswHash { get; set; }

        //public User(string username, string password)
        //{
        //    Username = username;
        //    Password = password;
        //    GetPswHash(password);
        //}
        public User(string username, string password ,byte[] pswHash, byte[] pswSalt)
        {
            Username = username;
            Password = password;
            PswSalt = pswSalt;
            PswHash = pswHash;

        }

        public void GetPswHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PswSalt =  hmac.Key;
                PswHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public bool CheckPsw(string password) 
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PswSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            return hash.SequenceEqual(PswHash);
        }
    }
}
