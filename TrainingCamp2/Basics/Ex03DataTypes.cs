//Data Types: 
/*
A data type defines the kind of data that a variable can store. 
C# uses different data types to store different kinds of information that it needs for computing. 
Data types help in allocating the required memory, so that it is not wasted. 
Helps the compiler dedect any programming errors before execution. 
Improves the programmming peformance. 

C# hs 3 kinds of data types:
Value types
Reference types
Pointer types
//All data types in C#, have wrapper types that are part of the .NET Framework
var data type:
*/
using System;
namespace CSharpBasics
{
    class DataTypesExample
    {

       static void ConvertExample()
        {
           int iValue = Convert.ToInt32("123");//Convert string to a integer.
           Console.WriteLine("The value is {0} and its data type is{1}", iValue, iValue.GetType().FullName);
        }
        static void usingVarKeyword()
        {
            var fruit = "Apple";//fruit becomes string as it is assigned to string. 
            var age = 49;//age becomes integer as U R assigning int value to it. 
            var price = 456.56; 
            Console.WriteLine("The Data type of fruit is " + fruit.GetType().Name);
            Console.WriteLine("The Data type of age is " + age.GetType().Name);
            Console.WriteLine("The Data type of price is " + price.GetType().Name);

        }
        static void firstExample()
        {
            byte value = 123;
            short value2 = 24435;
            decimal dValue = decimal.MaxValue;
            double dValue2 = 234.456;

            Console.WriteLine("The Byte value is {0}\nThe short value is {1}\nThe double value is {2}", value, value2, dValue2);

            Console.WriteLine("The value of decimal is {0}", dValue);//interpollation syntax.

        }
        static void secondExample()
        {
            //Example for taking inputs from the user. 
            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());//Converts the string to a integer. if the conversion fails, the system shall throw Exception. 
            
            Console.WriteLine("Enter the price of the product");
            double prodValue = double.Parse(Console.ReadLine());
            Console.WriteLine("The age is {0}", age);
            Console.WriteLine("The product price is {0:C}", prodValue);

        }

        static void DateTimeExample()
        {
            Console.WriteLine("Enter the Date of birth as dd/MM/yyyy");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("The year of birth is " + dob.Year);
            var span = DateTime.Now - dob;
            var totalYears = (int)span.Days/365.25;//Typecast to integer. All decimal values will be converted to the closest whole no
            Console.WriteLine("The Actual Age is " + totalYears);
        }
        static void Main(string[] args)
        {
            //value types: integral, decimal, others.
            //integral: byte(System.Byte), short(System.Int16), int(System.Int32), long(System.Int64).
            //decimal: float(System.Single), double(System.Double), decimal(System.Decimal)           

            //firstExample();

            //secondExample();

            //DateTimeExample();

            //usingVarKeyword();

            //ConvertExample();

        }
    }
}