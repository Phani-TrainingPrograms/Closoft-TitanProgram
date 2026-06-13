using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace BaseClassLib
{
    public  interface IEmployeeDB
    {
        void AddEmployee(Employee emp);
        void UpdateEmployee(int id, Employee emp);
        void DeleteEmployee(int id);

        List<Employee> GetAllEmployees();
    }

    public interface IDeptDB
    {
        void AddDept(Dept dept);
        void UpdateDept(int id, Dept dept);
        void DeleteDept(int id);

        List<Dept> GetAllDepartments();
    }

    public class DepartmentDB : IDeptDB
    {
        const string STRSELECT = "SELECT * FROM DEPT";
        String STRCONNECTION = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public void AddDept(Dept dept)
        {
            throw new NotImplementedException();
        }

        public void DeleteDept(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dept> GetAllDepartments()
        {
            List<Dept> depts = new List<Dept>(); ;
            using(var con = new SqlConnection(STRCONNECTION))
            {
                using(var cmd = con.CreateCommand())
                {
                    cmd.CommandText = STRSELECT;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        var dept = new Dept
                        {
                            DeptId = Convert.ToInt32(reader["DeptId"]),
                            DeptName = reader[1].ToString()
                        };
                        depts.Add(dept);
                    }
                }
            }
            return depts;
        }

        public void UpdateDept(int id, Dept dept)
        {
            throw new NotImplementedException();
        }
    }

    public class EmployeeDB : IEmployeeDB
    {
        const string STRINSERT = "Insert into Employee values(@id, @name, @address, @mobile, @dept)";
        const string STRSELECT = "SELECT * FROM EMPLOYEE";
        String STRCONNECTION = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public void AddEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(STRINSERT, con);
            cmd.Parameters.AddWithValue("@id", emp.EmpId);
            cmd.Parameters.AddWithValue("@name", emp.EmpName);
            cmd.Parameters.AddWithValue("@address", emp.EmpAddress);
            cmd.Parameters.AddWithValue("@mobile", emp.EmpContactNo);
            cmd.Parameters.AddWithValue("@dept", emp.DeptId);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }


        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> Employees = new List<Employee>(); ;
            using(var con = new SqlConnection(STRCONNECTION))
            {
                using(var cmd = con.CreateCommand())
                {
                    cmd.CommandText = STRSELECT;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        var Employee = new Employee
                        {
                            EmpId = Convert.ToInt32(reader[0]),
                            EmpName = reader[1].ToString(),
                            EmpAddress = reader[2].ToString(),
                            EmpContactNo = Convert.ToInt64(reader[3].ToString()),
                            DeptId = string.IsNullOrEmpty(reader[4].ToString()) ? 0 : Convert.ToInt32(reader[4]),
                        };
                        Employees.Add(Employee);
                    }
                }
            }
            return Employees;
        }

        public void UpdateEmployee(int id, Employee emp)
        {
            throw new NotImplementedException();
        }
    }

}
