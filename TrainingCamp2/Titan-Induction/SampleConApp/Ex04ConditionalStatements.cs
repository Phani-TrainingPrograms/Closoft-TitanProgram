using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//if U want to execute the statements on condition, then we use conditional statements. if the condition satisfies a section of code will execute, else another section of the code will execute. 
namespace SampleConApp
{
    //assume that your machine provides value from 0.1 to 0.5, it should display the conveyer shall move at slow speed. 
    //if the value is greater than 0.5 and less than 1, then the conveyer shall move at medium speed. 
    //if the value is greater than 1 then the conveyer shall move at fast speed. 
    internal class Ex04ConditionalStatements
    {
        static Random random = new Random(0);
        static void setConveyerSpeed(double value)
        {
            if(value > 0.1 && value <= 0.5)
            {
                Console.WriteLine("Speed allowed is optimal speed");
            }
            else if(value > 0.5 && value <=1)
            {
                Console.WriteLine("Speed allowed is mediuem speed");
            }
            else
            {
                Console.WriteLine("Speed allowed is at max speed");
            }
        }
        
        static void setColorToText(double value)
        {
            var obtained = new Random().Next(5);
            Console.WriteLine("The obtained value is " + obtained);
            var result = value /100 * obtained - random.NextDouble();
            if(obtained < 3)
            {
                if(result < 50)
                {
                    var oldColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(800, 250);
                    Console.WriteLine("PRINTING ALARM!!!!!!!");
                    Console.ForegroundColor = oldColor;
                }
                else
                {
                    var oldColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING GOOD TO GO!!!!!!!");
                    Console.ForegroundColor = oldColor;
                }
            }
            else
            {
                var oldColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("PRINTING WARNING TO GO!!!!!!!");
                Console.ForegroundColor = oldColor;
            }
        }

        static void IfExampleScenarios()
        {
            //simpleIfClauseExample();

            //Console.WriteLine("Enter the expected value from the machine");
            //double value = double.Parse(Console.ReadLine());
            //setConveyerSpeed(value);

            //real time scenario
            Console.WriteLine("Enter the expected value from the machine");
            while(true)
                setColorToText(double.Parse(Console.ReadLine()));
        }
        static void Main(string[] args)
        {
            //IfExampleScenarios();

            //SwitchExampleScenarios();

            //whileLoopScenario();
            
        }

        private static void whileLoopScenario()
        {
            //do..while loop shall execute a block of code atleast once and returns to execute the same block if a condition is satisfied.
            bool condition = false;
            do
            {
                condition = SwitchExampleScenarios();
            } while(condition == true);//should have a true/false condition....
            Console.WriteLine("Thanks for visiting our Application");
        }

        private static bool SwitchExampleScenarios()
        {
            DisplayMenu();
            Console.WriteLine("Type a Number from the choices mentioned above");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Console.WriteLine("Enter Customer details");
                    Console.WriteLine("Customer details are added");
                    Console.WriteLine("System has been updated");
                    break;
                case "2":
                    Console.WriteLine("Enter Customer ID to delete");
                    Console.WriteLine("Customer details are soft deleted");
                    Console.WriteLine("System has been updated");
                    break;
                case "3":
                    Console.WriteLine("Enter Customer details to update");
                    Console.WriteLine("Customer details are updated");
                    Console.WriteLine("System has been updated");
                    break;
                case "5":
                    Console.WriteLine("Do it URSelf");
                    break;
                case "4":
                    Console.WriteLine("Do it URSelf");
                    break;//Jump statement to exit the switch block
                default:
                    Console.WriteLine("Invalid Choice, please start the App again");
                    return false;//exits the function with a value or nothing. 
            }
            return true;
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("To Add New Customer --------->Press 1");
            Console.WriteLine("To Delete Customer ---------->Press 2");
            Console.WriteLine("To Update Customer ---------->Press 3");
            Console.WriteLine("To Delete Customer ---------->Press 4");
            Console.WriteLine("To Find a Customer ---------->Press 5");
            Console.WriteLine("PRESS ANY OTHER NUMBER TO EXIT");
        }

        private static void simpleIfClauseExample()
        {
            Console.WriteLine("Enter the Home City");
            string city = Console.ReadLine();
            if(city == "Hosur" || city == "Attibele")//looks for true condition
            {
                Console.WriteLine("The User can come to the office by own mode of transport");
            }
            else if(city == "Electronic City")
            {
                Console.WriteLine("User shall come by the shuttle available at 7 AM");
            }
            else//looks for false condition
            {
                Console.WriteLine("The User shall claim the transport cost to reach the office");
            }
        }
    }
}
/*
 * if conditions can be nested. 
 * An if condition can have another if condition within it. 
 */