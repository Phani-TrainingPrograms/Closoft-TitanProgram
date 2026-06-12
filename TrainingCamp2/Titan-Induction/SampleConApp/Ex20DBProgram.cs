using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;//For SQL Server access

namespace SampleConApp
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long MobileNo { get; set; }
    }
    interface IEmployeeDB
    {
        void AddEmployee(Employee emp);
        void AddEmployee(Employee emp, bool IsStoredProc);

        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int empId);
        List<Employee> GetAllEmployees();
    }

    class EmployeeDB : IEmployeeDB
    {

        string strConnection = ConfigurationManager.ConnectionStrings["titanConnection"].ConnectionString;
        const string STRSELECT = "SELECT * FROM EMPLOYEE"; 
        public void AddEmployee(Employee emp)
        {
            
            //create the connection
            var con = new SqlConnection(strConnection);
            var query = $"Insert into Employee values({emp.Id}, '{emp.Name}', '{emp.Address}', {emp.MobileNo})";
            
            //create the command and associate the connection and the statement
            var cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            //fill the values
            try
            {
                con.Open();
                //execute the command
                var rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected != 1)
                {
                    throw new Exception("Failed to Add Employee");
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                //close the connection. 
                con.Close();
            }
        }

        public void DeleteEmployee(int empId)
        {
            //DELETE FROM EMPLOYEE WHERE ID = empId
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            var list = new List<Employee>();
            //create the connection
            var con = new SqlConnection(strConnection);
            //create the command
            var cmd = new SqlCommand(STRSELECT, con);
            //open the connection
            try
            {
                con.Open();
                //execute the command
                var reader = cmd.ExecuteReader();
                //read each record and convert to Employee object
                while(reader.Read())
                {
                    var emp = new Employee
                    {
                        Id = Convert.ToInt32(reader[0]),
                        Name = Convert.ToString(reader[1]),
                        Address = Convert.ToString(reader[2]),
                        MobileNo = Convert.ToInt64(reader[3])
                    };
                    //Add the object to the List<Employee>
                    list.Add(emp);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //finally close the connection
                con.Close();
            }
            return list;
            //return the List<Employee>
        }

        public void UpdateEmployee(Employee emp)
        {
            var con = new SqlConnection(strConnection);
            var query = $"Update Employee Set FullName = '{emp.Name}', MobileNo = {emp.MobileNo}, Address = '{emp.Address}' where Id = {emp.Id}";
            var cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally 
            { 
                con.Close(); 
            }
        }

        public void AddEmployee(Employee emp, bool IsStoredProc)
        {
            var connection = new SqlConnection(strConnection);
            var cmd = new SqlCommand("AddEmployee", connection);//give the name of the stored proce
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", emp.Id);
            cmd.Parameters.AddWithValue("@name", emp.Name);
            cmd.Parameters.AddWithValue("@address", emp.Address);
            cmd.Parameters.AddWithValue("@mobile", emp.MobileNo);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
    internal class Ex20DBProgram
    {
        const string STRQUERY = "SELECT * FROM EMPLOYEE";
        const string STRCONNECTION = "Data Source=.\\SQLEXPRESS;Initial Catalog=TitanDb;Integrated Security=True;Encrypt=False";
        static IEmployeeDB db = new EmployeeDB();
        static void Main(string[] args)
        {
            //3 classes: Connection, Command and DataReader
            //ReadRecordsFromDb();
            //UpdateEmployee();
            InsertEmployee();
            DisplayEmployees();
        }

        private static void UpdateEmployee()
        {
            try
            {
                var emp = new Employee
                {
                    Id = ConsoleUtil.GetNumber("Enter the Id to update"),
                    Name = ConsoleUtil.GetString("Enter the Name to update"),
                    Address = ConsoleUtil.GetString("Enter the Address to update"),
                    MobileNo = long.Parse(ConsoleUtil.GetString("Enter the mobile no to update"))
                };
                db.UpdateEmployee(emp);
                Console.WriteLine("Employee updated successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void InsertEmployee()
        {
            try
            {
                var emp = new Employee
                {
                    Id = ConsoleUtil.GetNumber("Enter the Id"),
                    Name = ConsoleUtil.GetString("Enter the Name"),
                    Address = ConsoleUtil.GetString("Enter the Address"),
                    MobileNo = long.Parse(ConsoleUtil.GetString("Enter the mobile no"))
                };
                db.AddEmployee(emp, true);
                Console.WriteLine("Employee added successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DisplayEmployees()
        {
            db.GetAllEmployees().ForEach(e =>
            {
                Console.WriteLine(e.Id);
                Console.WriteLine(e.Name);
                Console.WriteLine(e.Address);
                Console.WriteLine(e.MobileNo);
            });
        }

        private static void ReadRecordsFromDb()
        {
            var connection = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(STRQUERY, connection);
            try
            {
                connection.Open();
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine($"{reader["FullName"]} from {reader[2]}");
                }
                connection.Close();
            }
            catch(SqlException)
            {
                Console.WriteLine("SQL related error occured");

            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
