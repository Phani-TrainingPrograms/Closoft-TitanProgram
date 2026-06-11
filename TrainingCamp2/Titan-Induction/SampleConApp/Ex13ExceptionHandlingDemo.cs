using System;
using System.IO;
using System.Net.Http.Headers;
/*
 * Exception Handling: Is scoped to handle any unexpected scenarios where there is a chance of a App crash 
 * try...catch...finally block is used to handle any exceptions. 
 * All Exceptions raised by the system are objects derived from System.Exception. This is the base class for all Exceptions. 
 * try block will try to execute a set of statements.
 * If any Exception occurs, the execution moves to catch block. 
 * finally block will be executed on all conditions: either try or catch. 
 * In a layered architecture, U handle exceptions at each layer and funnel(Send back) the Exception to the caller. 
 */
namespace SampleConApp
{

    class DatabaseComponent
    {
        /// <summary>
        /// Adds a new Employee
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void AddEmployee()
        {
            throw new NotImplementedException();
        }
    }
    internal class Ex13ExceptionHandlingDemo
    {
        static void Main(string[] args)
        {
            Retry:
            Console.WriteLine("Enter the Number");
            try
            {
                var component = new DatabaseComponent();
                component.AddEmployee();
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine("The Entered number is " + num);
            }
            catch(NotImplementedException)
            {
                Console.WriteLine("Yet to be implemented");
            }
            catch(FormatException)
            {
                Console.WriteLine("User should enter valid number");
                goto Retry;
            }
            catch(OverflowException)
            {
                Console.WriteLine("Value was either too large or too small for an Integer whole number");
                goto Retry;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unknown Error has occured, please restart the App");
                Console.WriteLine("The System generated the following message:");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //clean up operations will be written here. 
                Console.WriteLine("Program terminated");
            }
        }
    }
}
