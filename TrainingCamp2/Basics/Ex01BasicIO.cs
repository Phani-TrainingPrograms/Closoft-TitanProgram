using System;

namespace CSharpBasics
{
   

    class Ex01BasicIO
    {
        static void OutputDemo()
        {
            Console.WriteLine("Hello World!");//Console is a pre-defined class and its functions/Properties are invoked using the classname instead of an object.  

            Console.WriteLine("My Name is Phaniraj");
            Console.WriteLine("I am from Bangalore");
            Console.WriteLine("My occupation is Consultancy on .NET");
            Console.Write("I also provide training to Titan");
            Console.Write("its office is in Hosur");
        }
        static void Main(string[] args)
        {
            OutputDemo();
        }
    }
}