using System;
using BaseClassLib;

namespace SampleConApp
{
    class DerivedClass : BaseClass
    {
        public void DerivedTestFunc() => Console.WriteLine("Derived class Test Func");
    }
    internal class Ex15InheritanceDemo
    {
        static void Main(string[] args)
        {
            DerivedClass cls = new DerivedClass();
            cls.TestFunc();
            cls.DerivedTestFunc();
        }
    }
}
