using System;
using System.Diagnostics; //Telling the .NET that we are using few classes from that namespace. 

/*
Any input that comes into the system is a string. 
Any output that goes out of the system is a string.  
*/
namespace CSharpBasics
{
    class SecondExample
    {
        static void Main(string[] args)
        {
            //todo: Ask the user a question, get an answer and display the answer in proper format. 
            System.Console.WriteLine("Enter the Name: ");
            var name = Console.ReadLine();

            System.Console.WriteLine("Enter the Address:");
            var address  = Console.ReadLine();

            System.Console.WriteLine("Enter the Salary:");
            var salary  = Console.ReadLine();

            //process it and display
            Console.WriteLine("The Name entered is " + name + "\nThe Address is " + address + "\nThe Salary provided is Rs. " + salary);
            
        }
    }
}
