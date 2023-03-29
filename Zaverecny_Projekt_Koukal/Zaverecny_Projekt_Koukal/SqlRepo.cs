﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zaverecny_Projekt_Koukal
{
    public class SqlRepo
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FirmaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public SqlRepo()
        {
            
        }


        public User GetUser(string username)
        {
            User user = null;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Username,Password,Role FROM Users WHERE Username=@username";
            cmd.Parameters.AddWithValue("username", username);
            
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user = new User(reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["Role"]));
            }
            connection.Close();
            return user;

        }

        public static List<User> LoadUsers() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Users";

            SqlDataReader reader = cmd.ExecuteReader();
            List<User> listUsers = new List<User>();
            while (reader.Read())
            {
                listUsers.Add(new User(Convert.ToInt32(reader["IdUser"]), reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["Role"]), Convert.ToInt32(reader["IdEmployee"])));
            }
            connection.Close();
            return listUsers;
        }

        public static void DeleteUser(int idUser) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Users WHERE IdUser=@idUser";
            cmd.Parameters.AddWithValue("idUser", idUser);
            cmd.ExecuteNonQuery(); 
            connection.Close();
        }



    }
}