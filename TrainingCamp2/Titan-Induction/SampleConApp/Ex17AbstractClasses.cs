using System;
//Abstract class is a class that contains one or more abstract methods in it. However, it can contain normal methods also. 
//Abstract methods are functions that are not implemented but only declared int the class.
//As Abstract classes are incomplete Classes, they cannot be instantiated. 
namespace SampleConApp
{

    abstract class AbsClass
    {
        public abstract void AbsFunction();
        public void NormalFunc() => Console.WriteLine("Normal Func in Abstract class");
    }
    //if a class is deriving from an abstract class, it must implement the abstract methods, else, even this class should be marked as abstract. 
    class ImplementorClass : AbsClass
    {
        public override void AbsFunction()//abstract methods are implemented with override keyword. 
        {
            Console.WriteLine("Abs Function implemented in the Abstract class");
        }
    }
    internal class Ex17AbstractClasses
    {

        static void Main(string[] args)
        {
            AbsClass instance = new ImplementorClass();
            instance.NormalFunc();
            instance.AbsFunction();//as it is overriden, the derived class method itself will be called. 
        }
    }
}
