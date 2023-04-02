using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zaverecny_Projekt_Koukal
{
    public class SqlRepo
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\GITHUB\ZAVERECNYPROJEKTIT4_2023\DBO\FIRMADB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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
            cmd.CommandText = "SELECT Username,Password,Role,IdEmployee FROM Users WHERE Username=@username";
            cmd.Parameters.AddWithValue("username", username);
            
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user = new User(reader["Username"].ToString(), Convert.ToInt32(reader["Role"]));
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
                listUsers.Add(new User(Convert.ToInt32(reader["IdUser"]), reader["Username"].ToString(), Convert.ToInt32(reader["Role"]), Convert.ToInt32(reader["IdEmployee"])));
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

            HMACSHA512 hmac = new HMACSHA512();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Users (Username,PasswordHash,PasswordSalt,Role,IdEmployee) VALUES (@username,@hash,@salt,@role,@idEmployee)";
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("hash", hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
            cmd.Parameters.AddWithValue("salt", hmac.Key);
            cmd.Parameters.AddWithValue("role", role);
            cmd.Parameters.AddWithValue("idEmployee", idEmployee);
            cmd.ExecuteNonQuery(); 
            connection.Close();
        }


        public static User CheckLogin(string username, string password)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Users WHERE Username=@name";
            command.Parameters.AddWithValue("name", username);
            SqlDataReader reader = command.ExecuteReader();
            User user = null;
            if (reader.Read())
            {
                HMACSHA512 hmac = new HMACSHA512((byte[])reader[3]);
                if (hmac.ComputeHash(Encoding.UTF8.GetBytes(password)).SequenceEqual((byte[])reader[2]))
                {
                    user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(4), reader.GetInt32(5));
                }
            }
            reader.Close();
            conn.Close();
            return user;
        }

        public static void EditUser( int idUser,string username, string password, int role)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            HMACSHA512 hmac = new HMACSHA512();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Users SET Username=@username,Password=@password,Role=@role WHERE IdUser=@idUser";
            cmd.Parameters.AddWithValue("idUser", idUser);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("hash", hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
            cmd.Parameters.AddWithValue("salt", hmac.Key);
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

        public static void AddEmployee(string firstname, string lastname, DateTime birthDate, string email, int phone)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Employees (Firstname,Lastname,BirthDate,Email,Phone) VALUES (@firstname,@lastname,@birthDate,@email,@phone)";
            cmd.Parameters.AddWithValue("firstname", firstname);
            cmd.Parameters.AddWithValue("lastname", lastname);
            cmd.Parameters.AddWithValue("birthDate", birthDate);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static void EditEmployee(int idEmployee, string firstname, string lastname, DateTime birthDate, string email, int phone)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Employees SET Firstname=@firstname,Lastname=@lastname,BirthDate=@birthDate,Email=@email,Phone=@phone WHERE IdEmployee=@idEmployee";
            cmd.Parameters.AddWithValue("idEmployee", idEmployee);
            cmd.Parameters.AddWithValue("firstname", firstname);
            cmd.Parameters.AddWithValue("lastname", lastname);
            cmd.Parameters.AddWithValue("birthDate", birthDate);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // Začátek Contract metod a funkcí
        public static List<Contract> LoadContracts()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contracts";

            SqlDataReader reader = cmd.ExecuteReader();
            List<Contract> listContracts = new List<Contract>();
            while (reader.Read())
            {
                listContracts.Add(new Contract(Convert.ToInt32(reader["IdContract"]), reader["Customer"].ToString(), reader["Description"].ToString()));
            }
            connection.Close();
            return listContracts;
        }

        public static void DeleteContract(int idContract)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Contracts WHERE IdContract=@idContract";
            cmd.Parameters.AddWithValue("idContract", idContract);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void AddContract(string customer, string description)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Contracts (Customer,Description) VALUES (@customer,@description)";
            cmd.Parameters.AddWithValue("customer", customer);
            cmd.Parameters.AddWithValue("description", description);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void EditContract(int idContract, string customer, string description)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Contracts SET Customer=@customer,Description=@description WHERE IdContract=@idContract";
            cmd.Parameters.AddWithValue("idContract", idContract);
            cmd.Parameters.AddWithValue("customer", customer);
            cmd.Parameters.AddWithValue("description", description);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // Začátek WorkType metod a funkcí
        public static List<WorkType> LoadWorkTypes()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM WorkTypes";

            SqlDataReader reader = cmd.ExecuteReader();
            List<WorkType> listWorkTypes = new List<WorkType>();
            while (reader.Read())
            {
                listWorkTypes.Add(new WorkType(Convert.ToInt32(reader["IdWorkType"]), reader["Name"].ToString(), reader["Description"].ToString()));
            }
            connection.Close();
            return listWorkTypes;
        }

        public static void DeleteWorkType(int idWorkType)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM WorkTypes WHERE IdWorkType=@idWorkType";
            cmd.Parameters.AddWithValue("idWorkType", idWorkType); // ochrana SQL insectionu 
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void AddWorkType(string name, string description)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO WorkTypes (Name,Description) VALUES (@name,@description)";
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("description", description);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void EditWorkType(int idWorkType, string name, string description)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE WorkTypes SET Name=@name,Description=@description WHERE IdWorkType=@idWorkType";
            cmd.Parameters.AddWithValue("idWorkType", idWorkType);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("description", description);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        // metody na select user, employee, contract a worktype podle id

        public static User GetUserById(int idUser)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Users WHERE IdUser=@id";
            cmd.Parameters.AddWithValue("id", idUser);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User(Convert.ToInt32(reader["IdUser"]), reader["Username"].ToString(), Convert.ToInt32(reader["Role"]), Convert.ToInt32(reader["IdEmployee"]));
            }
            else
            {
                return null;
            }
        }

        public static Employee GetEmployeeById(int idEmployee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Employees WHERE IdEmployee=@id";
            cmd.Parameters.AddWithValue("id", idEmployee);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Employee((int)reader["IdEmployee"], reader["Firstname"].ToString(), reader["Lastname"].ToString(), Convert.ToDateTime(reader["BirthDate"]), reader["Email"].ToString(), (int)reader["Phone"]);
            }
            else
            {
                return null;
            }
        }

        public static Contract GetContractById(int idContract)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contracts WHERE IdContract=@id";
            cmd.Parameters.AddWithValue("id", idContract);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Contract((int)reader["IdContract"], reader["Customer"].ToString(), reader["Description"].ToString());
            }
            else
            {
                return null;
            }
        }

        public static WorkType GetWorkTypeById(int idWorkType)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM WorkTypes WHERE IdWorkType=@id";
            cmd.Parameters.AddWithValue("id", idWorkType);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new WorkType(Convert.ToInt32(reader["IdWorkType"]), reader["Name"].ToString(), reader["Description"].ToString());
            }
            else
            {
                return null;
            }
        }

        // Začátek WorkHours metod a funkcí

        public static List<WorkHours> LoadWorkHours()
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM WorkHours";

            SqlDataReader reader = cmd.ExecuteReader();
            List<WorkHours> listWorkHours = new List<WorkHours>();
            while (reader.Read())
            {
                listWorkHours.Add(new WorkHours((int)reader["IdWorkHour"], ((int)reader["IdEmployee"]), ((int)reader["IdConctract"]), ((int)reader["IdWorkType"]), (int)reader["Hours"], Convert.ToDateTime(reader["InsertDate"]), ((int)reader["InsertUser"])));
                //listWorkHours.Add(new WorkHours(Convert.ToInt32(reader["IdWorkHour"])), (Convert.ToInt32(reader["IdEmployee"])), (Convert.ToInt32(reader["IdContract"])), (Convert.ToInt32(reader["IdWorkType"])), (Convert.ToInt32(reader["Hours"])), (Convert.ToInt32(reader["InsertDate"])), (Convert.ToInt32(reader["IdUser"])));
            }
            connection.Close();
            return listWorkHours;
        }

        public static void DeleteWorkHours(int idWorkHour)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM WorkHours WHERE IdWorkHour=@idWorkHour";
            cmd.Parameters.AddWithValue("idWorkHour", idWorkHour); // ochrana SQL insectionu 
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void AddWorkHours(int idEmloyee, int idConctract, int idWorkType, int hours, DateTime insertDate, int insertUser)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO WorkHours (IdEmployee, IdConctract, IdWorkType, Hours, InsertDate, InsertUser) VALUES (@idEmployee,@idConctract,@idWorkType,@hours,@insertDate,@insertUser)";
            cmd.Parameters.AddWithValue("idEmployee", idEmloyee);
            cmd.Parameters.AddWithValue("idConctract", idConctract);
            cmd.Parameters.AddWithValue("idWorkType", idWorkType);
            cmd.Parameters.AddWithValue("hours", hours);
            cmd.Parameters.AddWithValue("insertDate", insertDate);
            cmd.Parameters.AddWithValue("insertUser", insertUser);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void EditWorkHours(int idEmloyee, int idConctract, int idWorkType, int hours, DateTime insertDate, int insertUser)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE WorkHours SET IdEmployee=@idEmployee,IdConctract=@idConctract, IdWorkType=@idWorkType, Hours=@hours, InsertDate=@insertDate, InsertUser=@insertUser WHERE IdWorkHour=@idWorkHour";
            cmd.Parameters.AddWithValue("idEmployee", idEmloyee);
            cmd.Parameters.AddWithValue("idConctract", idConctract);
            cmd.Parameters.AddWithValue("idWorkType", idWorkType);
            cmd.Parameters.AddWithValue("hours", hours);
            cmd.Parameters.AddWithValue("insertDate", insertDate);
            cmd.Parameters.AddWithValue("insertUser", insertUser);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // Začátek UserForm metod a funkcí


    }
}
