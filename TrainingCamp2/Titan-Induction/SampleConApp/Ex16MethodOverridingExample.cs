using System;

//Method overriding is modifying a base class function in the dirived class. 
//Method overriding leads to runtime polymorphism. Same function with the same object will behave in different manner.
//The Base class function should be marked with virtual keyword
//Derived class can rewrite that function using override keyword. 

namespace SampleConApp
{
    class BaseClass
    {
        public virtual void TestFunc() => Console.WriteLine("Conducting sample base Test");
    }

    class SubClass : BaseClass
    {
        public override void TestFunc()
        {
            base.TestFunc();//Call the base functionality
            Console.WriteLine("Conducting More tests added from Base");
        }
    }

    /// <summary>
    /// Helper class creaeted to implement Factory pattern on objects. 
    /// </summary>
    class Activator
    {
        /// <summary>
        /// Gets the object of the Base class depending on the type asked form
        /// </summary>
        /// <param name="type">The type could be Base or Sub</param>
        /// <returns>An instantiated object</returns>
        /// <exception cref="Exception">When invalid type is sent as parameter</exception>
        public static BaseClass GetObject(string type)
        {
            if(type == "Base")
                return new BaseClass();
            else if(type == "Sub")
                return new SubClass();
            else
                throw new Exception("Invalid type");
        }
    }
    internal class Ex16MethodOverridingExample
    {
        static void Main(string[] args)
        {
            //BaseClass cls = new BaseClass();
            //cls.TestFunc();//Base version will be called. 

            //cls = new SubClass();
            //cls.TestFunc();//Derived version will be called


            ///////////////////2nd version/////////////////////
            Console.WriteLine("Enter the Type of object U want to create");
            var type = Console.ReadLine();
            BaseClass obj = Activator.GetObject(type);
            obj.TestFunc();
        }
    }
}
