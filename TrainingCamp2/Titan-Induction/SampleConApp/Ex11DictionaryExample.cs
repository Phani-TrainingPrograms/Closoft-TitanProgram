using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
/*
 * Dictionary is a Collection class used to store data as key-value pairs. 
 * Key will be unqiue to the collection. 
 * U can sort based on key. 
 * U can insert, delete or modify the collection. 
 * When U try to add the same key into the dictionary, it will throw an exception. 
 */
namespace SampleConApp
{
    class Ex11DictionaryExample
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();

        /// <summary>
        /// Adds a new user to the System
        /// </summary>
        /// <param name="username">UserName to add</param>
        /// <param name="password">Password to add</param>
        static void AddUser(string username, string password)
        {
            if(users.ContainsKey(username))
            {
                Console.WriteLine("User already registered by this name");
                return;
            }
            users[username] = password;
            //users.Add(username, password);//Add addes the key-value pair into the Dictionary. 
            Console.WriteLine("User added successfully");
        }

        static bool LoginUser(string username, string password)
        {
            if(!users.ContainsKey(username))
            {
                Console.WriteLine("User name is invalid or User is not registered");
                return false;
            }

            if(users[username] != password)
            {
                return false;
            }
            return true;
        }
        static string DisplayMenu()
        {
			Console.WriteLine("Welcome to Flipkart");
			Console.WriteLine("Press 1 to Login");
			Console.WriteLine("Press 2 to Register");
            return Console.ReadLine();
		}
        static void Main(string[] args)
        {
            users.Add("admin", "admin123");
            users.Add("su", "su123");
            users.Add("clerk", "clerk123");
			do
            {
                var choice = DisplayMenu();
                switch(choice)
                {
                    case "1": processLogin(); break;
                    case "2": processSignIn(); break;
                   default: 
                        Console.WriteLine("Invalid choice");
                        return;
                }
            } while(true);
        }

        private static void processSignIn()
        {
            Console.WriteLine("Welcome to Registration Process");
			Console.WriteLine("Enter the Username");
			string name = Console.ReadLine();

			Console.WriteLine("Enter the Password");
			string password = Console.ReadLine();

            AddUser(name, password);
            

		}

		private static void processLogin()
        {
            Console.WriteLine("Enter the Username");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine();
            if(LoginUser(name, password))
            {
                var old = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Welcome {name}");
                Console.ForegroundColor = old;
            }
            else
            {
				var old = Console.ForegroundColor;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"InValid UserName or Password");
				Console.ForegroundColor = old;
			}
        }
    }
}
