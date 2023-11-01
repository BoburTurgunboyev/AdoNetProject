using AdoNetProject.Dtos;
using AdoNetProject.Enums;
using AdoNetProject.Hash;
using AdoNetProject.Interfaces;
using System.Data.SqlClient;

namespace AdoNetProject.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";


        public void CreateEmployee(EmployeeDTO employee)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string query = $"insert into Employee(Name,Surname,Email,Login,Password,Status,Role) values('{employee.Name}', '{employee.Surname}', '{employee.Email}','{employee.Login}','{Hash512.ComputeSHA512HashFromString(employee.Password)}','{Status.Created}','{employee.Role}')";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader()) { }
                    Console.WriteLine("Employee Yaratildi");
                }
                catch
                {
                    Console.WriteLine("Bu UserName yoki Password Oldin ro'yxatdan utgan");
                }
            }
        }

        public void DeleteEmployee(int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string query = $"update Employee set Status = '{Status.Deleted}',DeletedDate = '{DateTime.UtcNow}' where Id = {EmployeeId} and Status <> 'Deleted';";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Uchirildi");
                }
            }
        }
        public void EmployeeDeepDelete(int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string query = $"delete from Employee where Id = {EmployeeId};";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Uchirildi");
                }
            }
        }
        public void GetAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string query = $"select * from Employee where Status <> 'Deleted'";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    bool res = false;
                    while (reader.Read())
                    {
                        res = true;
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Surname"]} {reader["Email"]} {reader["Login"]} {reader["Password"]} {reader["Status"]} {reader["CreatedDate"]} {reader["ModifyDate"]} {reader["DeletedDate"]}");
                    }
                    if (res == false)
                    {
                        Console.WriteLine("Ma'lumot topilmadi");
                    }
                }
            }
        }
        public void GetEmployeeById(int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string query = $"select * from Employee where Id = {EmployeeId} and Status <> 'Deleted'";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    bool res = false;
                    while (reader.Read())
                    {
                        res = true;
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Surname"]} {reader["Email"]} {reader["Login"]} {reader["Password"]} {reader["Status"]} {reader["CreatedDate"]} {reader["ModifyDate"]} {reader["DeletedDate"]}");
                    }
                    if (res == false)
                    {
                        Console.WriteLine("Ma'lumot topilmadi");
                    }
                }
            }
        }

        public void UpdateEmployee(int EmployeeId, EmployeeDTO employee)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string query = $"update Employee set Name = '{employee.Name}',surname = '{employee.Surname}',email = '{employee.Email}',login = '{employee.Login}',password = '{employee.Password}',status = '{Status.Updated}',role = '{employee.Role}',modifydate='{DateTime.Now}' where Id = {EmployeeId} and Status <> 'Deleted';";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Yangilandi");
                }
            }
        }
    }
}
