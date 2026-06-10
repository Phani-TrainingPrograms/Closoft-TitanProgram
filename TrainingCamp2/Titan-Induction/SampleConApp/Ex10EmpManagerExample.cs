using EMS.DataLayer;
using EMS.Entities;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entities
{
    class Employee
    {
        public int EmpId { get; set; }//get for reading and set for writing.
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
    }
}

//What is Repository Pattern. 
namespace EMS.DataLayer
{
    //Layer that interacts with the storage: In-memory, Files, Databases, Cloud 

    class EmployeeRepo
    {
        //data
        static List<Employee> _empList = new List<Employee>(); //Curently nothing is available...

        public void AddNewEmployee(Employee emp)
        {
            _empList.Add(emp);
        }

        public List<Employee> GetAllEmployees()
        {
            return _empList;
        }
    }
}

namespace EMS.UI
{
    internal class Ex10EmpManagerExample
    {
        class UserInterface
        {
            static string DisplayMenu()
            {
                Console.WriteLine("~~~~~~~~~~~~~~EMPLOYEE MANAGEMENT SOFTWARE~~~~~~~~~~~~~~~~~");
                Console.WriteLine("TO ADD NEW EMPLOYEE--------->PRESS 1");
                Console.WriteLine("TO VIEW ALL EMPLOYEES------->PRESS 2");
                Console.WriteLine("ANY OTHER KEY IS CONSIDERED AS EXIT");
                string choice = Console.ReadLine();
                return choice;
            }
            static void Main(string[] args)
            {
                bool looping = false;
                do
                {
                    string choice = DisplayMenu();
                    looping = processMenu(choice);
                } while(looping);
            }

            private static bool processMenu(string choice)
            {
                switch(choice)
                {
                    case "1":
                        processAddingFeature();
                        return true;
                    case "2":
                        displayRecordsFeature();
                        return true;
                    default:
                        break;
                }
                return false;
            }

            private static void displayRecordsFeature()
            {
                var repo = new EmployeeRepo();
                var records = repo.GetAllEmployees();
                foreach(var rec in records)
                {
                    Console.WriteLine(rec.Name);
                }
            }

            private static void processAddingFeature()
            {
                Employee record = new Employee();
                record.EmpId = 123;
                record.Name = "Phaniraj";
                record.Address = "Bangalore";
                record.Salary = 56000;
                EmployeeRepo repo = new EmployeeRepo();//Creating an object in C#.
                repo.AddNewEmployee(record);
                Console.WriteLine("Employee added successfully");
            }
        }
    }
}
