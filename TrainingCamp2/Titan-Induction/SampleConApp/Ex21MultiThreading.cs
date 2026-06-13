using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Multi Threading allows multiple paths of execution within your App. 
//Every App executes as a Process within the OS. Each process can have one or more threads. Each Thread is a path of execution within the App. 
//In a typical program, Main Function represents the path of execution of the Main Thread. 
//A process will have atleast 1 thread, the main thread. If this thread terminates, App shall close. 
//A Thread in .NET is represented by a Delegate called ThreadStart. Delegate is like Function pointers of C++
//The object of a Delegate represents a function that U want to invoke.
//Every thread in .NET is represented by an object of a class called System.Threading.Thread.
//Each thread will be associated with a function, that defines what it should do when the thread begins.
//It is done using Delegate. 
//lock block performs Synchronization of the resoruces. So that only one thread should be able to access the resource at a time. This is called as MONITOR(Multiple Threads) or MUTEX(Multple processes: Single instance of the App to run).  
//Further to Explore: 
namespace SampleConApp
{
    internal class Ex21MultiThreading
    {
        static int count = 0;
        static void PerformComplexOperation()
        {
            lock(typeof(Ex21MultiThreading))
            {
                count++;
                Console.WriteLine($"[Complex] function has started with Count {count} invoked by Thread {Thread.CurrentThread.Name}");
                for(int i = 0; i < 20; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"A Sequence of execution in Complex Function with Count {count}");
                }

                Console.WriteLine("[Complex] function has terminated");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("[Main] function has started");
            //PerformComplexOperation(); Try this function before trying threading....

            Thread thread = new Thread(PerformComplexOperation);//A Function is passed as argument to the object creation... 
            //It is internally creating an object of a ThreadStart delegate and mapping the function to the object. So that the object is passed as arg to UR function. 
            thread.Name = "First Thread";
            thread.IsBackground = true;//Mkes the thread a background thread
            thread.Start(); //Starts the thread and internally invokes the function that U hve passed as argument. 

            Thread thread2 = new Thread(PerformComplexOperation);
            thread2.Name = "Second Thread";
            thread2.IsBackground = true;
            thread2.Start();

            for(int i = 0; i < 20; i++)
            {
                Thread.Sleep(1000);
                //Uncomment to see how suspend and resume works....
                //if(i == 5)
                //    thread.Suspend();
                Console.WriteLine("A Sequence of execution in Main");
            }
            //if(thread.ThreadState == ThreadState.Suspended)
            //   thread.Resume();   
            Console.WriteLine("[Main] function has terminated");

        }
    }
}
