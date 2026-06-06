using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class Ex02BasicIO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            string address = Console.ReadLine();

            Console.WriteLine($"The Name is {name} from {address}");
        }
    }
}
