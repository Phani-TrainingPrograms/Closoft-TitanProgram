using System;
using System.Collections.Generic;
using System.Data;

//Interfaces are similar to abstract classes, but contain only abstract methods in them. interfaces cannot have functions with body. interface functionsc can contain only declarations. 
//A class that implements the interface must implement all the methods of the interface in public scope.
//Interfaces cannot have fields in them. However, U can have properties. 
//A class can implement multiple interfaces which cannot be done with classes. 
//All interface members are default public and will always be public. So no access specifiers are to be used
//All interfaces are abstract classes, but all abstract classes are not interfaces. 
namespace SampleConApp
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BillAmount { get; set; }
        public DateTime BillDate { get; set; }
    }
    interface ICustomerRepo
    {
        void AddCustomer(Customer cst);
        void UpdateCustomer(int id, Customer cst);

        void DeleteCustomer(int id);           
        List<Customer> GetCustomerList();
    }

    class CustomerRepo : ICustomerRepo
    {
        List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer cst)
        {
            if(cst == null)
                throw new Exception("Customer details are not set");
            customers.Add(cst);
        }

        public void DeleteCustomer(int id)
        {
            for(int i = 0; i < customers.Count; i++)
            {
                if(customers[i].Id == id)
                {
                    customers.RemoveAt(i);//Removes the element at that index. Remove takes the arg of the element to remove.
                    return;//exits the function....
                }
            }
            throw new Exception("Customer not found to delete");

        }
   
        public List<Customer> GetCustomerList()
        {
            return customers;
        }

        public void UpdateCustomer(int id, Customer cst)
        {
            //loop thru the customer list.
            for (int i = 0;i < customers.Count; i++)
            {
                //find the matching customer based on id
                if(customers[i].Id == id)
                {
                   //set the new values to that customer
                    customers[i].Name = cst.Name;
                    customers[i].BillAmount = cst.BillAmount;
                    customers[i].BillDate = cst.BillDate;
                    //exit the function.
                    return;
                }
            }
            throw new Exception("Customer not found to update");
        }
    }


    internal class Ex19InterfaceExample
    {
        static ICustomerRepo repo = null;//Not usable object/
        static void Main(string[] args)
        {
            repo = new CustomerRepo();
            repo.AddCustomer(
                new Customer
                {
                    Id = ConsoleUtil.GetNumber("Enter the Customer Id"),
                    Name = ConsoleUtil.GetString("Enter the Name"),
                    BillAmount = 5600,
                    BillDate = DateTime.Now.AddDays(-34)
                    //BillDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null)
                });

            repo.UpdateCustomer(123, new Customer
            {
                Id = 123,
                Name = "Phani raj B.N.",
                BillAmount = 5650,
                BillDate = DateTime.Now.AddDays(-24)
                //BillDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null)
            });
            var data = repo.GetCustomerList();
            foreach(var rec in data)
            {
                Console.WriteLine($"The Customer {rec.Name} has purchased products of worth Rs.{rec.BillAmount} on {rec.BillDate.ToString("dd-MMM-yy")}");
            }
            //create a menu driven program
            //based on choice, app will call the appropriate feature. 
        }
    }
}
