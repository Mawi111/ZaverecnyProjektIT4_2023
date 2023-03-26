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

        public void AddUser(string userName, int idEmployee, int role, byte[] password, byte[] passwordSalt)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Users values (@idEmployee,@userName,@password,@passwordSalt,@role)";
                    cmd.Parameters.AddWithValue("userName", userName);
                    cmd.Parameters.AddWithValue("idEmployee", idEmployee);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    cmd.Parameters.AddWithValue("role", role);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void DeleteUser(int idUser)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Users where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public User GetUser(string userName)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(Connection))
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
                            user = new User(reader["UserName"].ToString(), Convert.ToInt32(reader["IdUser"]), (byte[])reader["Password"], (byte[])reader["PasswordSalt"], Convert.ToInt32(reader["Role"]));
                        }
                        else
                        {
                            MessageBox.Show("Uživatel s takovýmto uživatelským jménem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return user;
        }

        public User GetUser(int id)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where IdUser=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(Convert.ToInt32(reader["IdUser"]), Convert.ToString(reader["UserName"]), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["Role"]));
                        }
                        else
                        {
                            MessageBox.Show("Uživatel s takovýmto uživatelským jménem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return user;
        }

        public bool IsUsered(int id)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where IdEmployee=@idEmployee";
                    cmd.Parameters.AddWithValue("idEmployee", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(Convert.ToInt32(reader["IdUser"]));
                        }
                    }
                }
                conn.Close();
            }
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
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User(Convert.ToInt32(reader["IdUser"]), reader["UserName"].ToString(), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["Role"])));
                        }
                    }
                }
                conn.Close();
            }
            return users;
        }

        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Roles";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(new Role(reader["Name"].ToString(), Convert.ToInt32(reader["IdRole"])));
                        }
                    }
                }
                conn.Close();
            }
            return roles;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Employees";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee(Convert.ToInt32(reader["IdEmployee"]), reader["FirstName"].ToString(), reader["LastName"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return employees;
        }

        public Employee GetEmployee(int idEmployee)
        {
            Employee employee = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Employees where IdEmployee=@id";
                    cmd.Parameters.AddWithValue("id", idEmployee);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee(Convert.ToInt32(reader["IdEmployee"]), reader["FirstName"].ToString(), reader["LastName"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Zaměstnanec s takovýmto identifikačním číslem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return employee;
        }

        public Role GetRole(int idRole)
        {
            Role role = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Roles where IdRole=@id";
                    cmd.Parameters.AddWithValue("id", idRole);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new Role(reader["Name"].ToString(), 0);
                        }
                        else
                        {
                            MessageBox.Show("Role s takovýmto identifikačním číslem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return role;
        }

        public Role GetRole(string roleName)
        {
            Role role = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Roles where Name=@roleName";
                    cmd.Parameters.AddWithValue("roleName", roleName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new Role(null, Convert.ToInt32(reader["IdRole"]));
                        }
                        else
                        {
                            MessageBox.Show("Role s takovýmto názvem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return role;
        }

        public void UpdateUser(string userName, int idRole, int idUser)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Users set UserName=@userName,Role=@idRole where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("userName", userName);
                    cmd.Parameters.AddWithValue("idRole", idRole);
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void ResetUserPassword(int idUser, byte[] password, byte[] passwordSalt)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Users set Password=@password,PasswordSalt=@passwordSalt where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void ChangeUserPassword(int idUser, byte[] password, byte[] passwordSalt)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Users set Password=@password,PasswordSalt=@passwordSalt where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
