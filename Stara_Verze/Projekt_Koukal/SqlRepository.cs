using System;
using System.Collections.Generic;
using System.Data;
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
        public string Connection { get; set; }

        public SqlRepository()
        {
            Connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public void AddUser(string username, string password, int idEmployee, int role)
        {
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into Users values (@idEmployee,@username,@password,@role)";
            cmd.Parameters.AddWithValue("userName", username);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("idEmployee", idEmployee);
            cmd.Parameters.AddWithValue("role", role);
            
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        public void DeleteUser(int idUser)
        {
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
           
            cmd.CommandText = "delete from Users where IdUser=@idUser";
            cmd.Parameters.AddWithValue("idUser", idUser);
            cmd.ExecuteNonQuery();
     
            conn.Close();
        }

        public User GetUser(string username)
        {
            User user = null;
            SqlConnection conn = new SqlConnection(Connection);

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "select * from Users where UserName=@username";
            cmd.Parameters.AddWithValue("userName", username);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                user = new User(Convert.ToInt32(reader["IdRole"]), Convert.ToInt32(reader["Role"]), reader["Username"].ToString(), (string)reader["Password"]);
            }
            else
            {
                MessageBox.Show("Uživatel s takovýmto uživatelským jménem neexistuje!");
            }

            conn.Close();
            return user;
        }

        public User GetUser(int id)
        {
            User user = null;
            SqlConnection conn = new SqlConnection(Connection);
           
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Users where IdUser=@id";
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                user = new User(Convert.ToInt32(reader["IdUser"]), Convert.ToString(reader["Username"]), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["Role"]));
            }
            else
            {
                MessageBox.Show("Uživatel s takovýmto uživatelským jménem neexistuje!");
            }
            
            conn.Close();
            return user;
        }

        public bool IsUsered(int id)
        {
            User user = null;
            SqlConnection conn = new SqlConnection(Connection);
           
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
              
            cmd.CommandText = "select * from Users where IdEmployee=@idEmployee";
            cmd.Parameters.AddWithValue("idEmployee", id);
            SqlDataReader reader = cmd.ExecuteReader();
              
            if (reader.Read())
            {
                user = new User(Convert.ToInt32(reader["IdUser"]));
            }
            conn.Close();
            
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Users";
            
            SqlDataReader reader = cmd.ExecuteReader();   
            while (reader.Read())
            {
                users.Add(new User(Convert.ToInt32(reader["IdUser"]), reader["Username"].ToString(), Convert.ToInt32(reader["IdEmployees"]), Convert.ToInt32(reader["Role"])));
            }
            conn.Close();
            return users;
        }

        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            SqlConnection conn = new SqlConnection(Connection);
           
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
  
            cmd.CommandText = "select * from Roles";
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                roles.Add(new Role(Convert.ToInt32(reader["IdRole"]), Convert.ToString(reader["Rolename"])));
            }
            
            conn.Close();
            return roles;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Employee";
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                employees.Add(new Employee(Convert.ToInt32(reader["IdEmployee"]), reader["Firstname"].ToString(), reader["Lastname"].ToString()));
            }
            conn.Close();
            return employees;
        }

        public Employee GetEmployee(int idEmployee)
        {
            Employee employee = null;
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Employees where IdEmployee=@id";
            cmd.Parameters.AddWithValue("id", idEmployee);
            
            SqlDataReader reader = cmd.ExecuteReader();
                    
            if (reader.Read())
            {
                employee = new Employee(Convert.ToInt32(reader["IdEmployee"]), reader["Firstname"].ToString(), reader["Lastname"].ToString());
            }
            else
            {
                MessageBox.Show("Zaměstnanec s takovýmto identifikačním číslem neexistuje!");
            }
            conn.Close();
            return employee;
        }

        public Role GetRole(int idRole)
        {
            Role role = null;
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            
            cmd.CommandText = "select * from Roles where IdRole=@id";
            cmd.Parameters.AddWithValue("id", idRole);
            SqlDataReader reader = cmd.ExecuteReader();
                    
            if (reader.Read())
            {
                role = new Role(idRole,Convert.ToString(reader["Rolename"]));
            }
            else
            {
                MessageBox.Show("Taková role neexistuje");
            } 
            conn.Close();
            return role;
        }

        public Role GetRole(string rolename)
        {
            Role role = null;
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Roles where Rolename=@rolename";
            cmd.Parameters.AddWithValue("roleName", rolename);
            
            SqlDataReader reader = cmd.ExecuteReader();
                 
            if (reader.Read())
            {
                role = new Role(Convert.ToInt32(reader["IdRole"]), rolename);
            }
            else
            {
                MessageBox.Show("Role s takovýmto názvem neexistuje!");
            }
            conn.Close();
            return role;
        }

        public void UpdateUser(string username, int idRole, int idUser)
        {
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "update Users set Username=@username, IdRole=@idRole where IdUser=@idUser";
            cmd.Parameters.AddWithValue("idUser", idUser);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("role", idRole);
            cmd.ExecuteNonQuery();
            conn.Close();   
        }
    }
}
