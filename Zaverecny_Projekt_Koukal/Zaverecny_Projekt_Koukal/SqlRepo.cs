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

        public static User GetUserById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Users WHERE IdUser=@id";
            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User(Convert.ToInt32(reader["IdUser"]), reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["Role"]), Convert.ToInt32(reader["IdEmployee"]));
            }
            else
            {
                return null;
            }
        }

        public static Employee GetEmployeeById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Employees WHERE IdEmployee=@id";
            cmd.Parameters.AddWithValue("id", id);

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

        public static Contract GetContractById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contracts WHERE IdContract=@id";
            cmd.Parameters.AddWithValue("id", id);

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

        public static WorkType GetWorkTypeById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM WorkTypes WHERE IdWorkType=@id";
            cmd.Parameters.AddWithValue("id", id);

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
                listWorkHours.Add(new WorkHours((int)reader["IdWorkHours"], GetEmployeeById((int)reader["IdEmployee"]), GetContractById((int)reader["IdConctract"]), GetWorkTypeById((int)reader["IdWorkType"]), (int)reader["Hours"], Convert.ToDateTime(reader["InsertDate"]), GetUserById((int)reader["InsertUser"])));
            }
            connection.Close();
            return listWorkHours;
        }
    }
}
