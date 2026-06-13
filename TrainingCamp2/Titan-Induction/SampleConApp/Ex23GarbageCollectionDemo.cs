using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Myobject
    {
        public string Data { get; set; }

        //Constructor in OOP is a function that is called when an object is created. 
        public Myobject(string data) 
        { 
            this.Data = data;
            Console.WriteLine("object created for " + data);
        }
        ~Myobject()
        {
            Console.WriteLine("object Destroyed for " + Data);
        }

    }
    internal class Ex23GarbageCollectionDemo
    {
        static void CreateAndDeleteObjects()
        {
            for(int i = 0; i < 100; i++)
            {
                Myobject obj = new Myobject($"Apple {i}");
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        static void Main(string[] args)
        {
            CreateAndDeleteObjects();
            Console.WriteLine("Program is terminating");
        }
    }
}
