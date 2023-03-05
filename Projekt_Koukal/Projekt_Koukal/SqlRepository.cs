using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projekt_Koukal
{
    internal class SqlRepository
    {
        string connection;

        public SqlRepository(string connection)
        {
            this.connection = connection;
        }
        public void Login(string userName, string password)
        {
            if (userName != null || password != null)
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from Users where UserName=@userName";
                        cmd.Parameters.AddWithValue("userName", userName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show(reader["Username"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                
            }
        }
        public User GetUser(string userName)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where UserName=@userName";
                    cmd.Parameters.AddWithValue("userName", userName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(reader["Username"].ToString(), reader["Password"].ToString(), (byte[])reader["PasswordHash"], (byte[])reader["PasswordSalt"]);
                        }
                        else
                        {
                            MessageBox.Show("Nikdo takový neexistuje");
                        }
                    }
                }
                conn.Close();
            }
            return user;
        }
    }
}
