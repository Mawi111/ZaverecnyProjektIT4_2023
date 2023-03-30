using System;
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

        // Začátek User metod a funkcí

        public User GetUser(string username) // funkce pro LoginForm
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

        public static void AddUser(string username, string password, int role, int idEmployee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Users (Username,Password,Role,IdEmployee) VALUES (@username,@password,@role,@idEmployee)";
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("role", role);
            cmd.Parameters.AddWithValue("idEmployee", idEmployee);
            cmd.ExecuteNonQuery(); 
            connection.Close();
        }

        public static void EditUser( int idUser,string username, string password, int role)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Users SET Username=@username,Password=@password,Role=@role WHERE IdUser=@idUser";
            cmd.Parameters.AddWithValue("idUser", idUser);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("role", role);
            cmd.ExecuteNonQuery(); 
            connection.Close();
        }

        // Začátek Employee metod a funkcí
        public static List<Employee> LoadEmployees()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Employees";

            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> listEmployees = new List<Employee>();
            while (reader.Read())
            {
                listEmployees.Add(new Employee(Convert.ToInt32(reader["IdEmployee"]), reader["Firstname"].ToString(), reader["Lastname"].ToString(), Convert.ToDateTime(reader["BirthDate"]), reader["Email"].ToString(), Convert.ToInt32(reader["Phone"])));
            }
            connection.Close();
            return listEmployees;
        }

        public static void DeleteEmployee(int idEmployee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Employees WHERE IdEmployee=@idEmployee";
            cmd.Parameters.AddWithValue("idEmployee", idEmployee);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
