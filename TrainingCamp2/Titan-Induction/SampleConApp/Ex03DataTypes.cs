using System;

namespace SampleConApp
{
    //Data Types in C# are all from CTS(Common Type System). As multiple languages work with .NET, it has provided a common data type system that has to be adopted by all the languages of .NET. 
    //There are 2 types:
    //Value types: Variables store the value and Reference types(Variables store the location of the data from the heap).
    //Value Types are primitive types(old, classic)
    //Reference types: classes, strings, arrays, object
    internal class Ex03DataTypes
    {
        static void Main(string[] args)
        {
            int x = 123;//local variable
            double y = x;//Implicit casting
            Console.WriteLine("The value is " + x);

            double salary = 45000.56;
            Console.WriteLine($"The salary is {salary}");

            //Convert from double to int. 
            x = (int) salary; //typecasting/explicit casting to int from double.
            Console.WriteLine("The value is " + x);
            //We need typecasting for converting large range values to smaller range values in .NET.
            //Casting is unsafe and it might give abnormal values.
            //checked
            //{
            //    x = 123;            
            //    long lValue = x + int.MaxValue;
            //    x = (int) lValue;
            //    Console.WriteLine($"The value of x is {x}");
            //}
            {
                //Without using checked and using Convert class
                x = 123;
                long lValue = x + int.MaxValue;
                x = Convert.ToInt32(lValue);//Convert is safer. 
                Console.WriteLine($"The value of x is {x}");
            }
            //checked ensures that casting is safe and will throw an error if such anomalies occur. 
            //Convert class was available since .NET 2.0 where we can use its functions to perform conversions, if the conversions fail, it throws an Exception
        }
    }
}
/*
 * Data types in C#
 * Value types and reference types
 * Type conversion using type casting. 
 * Explicit vs. Implicit casting. 
 * Convert class
 * checked keywork. 
 */