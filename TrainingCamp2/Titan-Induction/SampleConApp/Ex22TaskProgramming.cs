using System;
using System.Threading;
using System.Threading.Tasks;

//Task Programming is new to C# 4.5 where U could take the support of multiple processors(Cores) of the OS.
//They execute parallelly in your application. Unlike threads which are resources,Task uses ThreadPool. Thread Pool is a collection of threads that are available within the .NET Runtime to manage itself. 
//Programmers can create tasks that can be executed by those threads, .NET will decide to which thread the task should be asigned 
//TPL or Task Parallel Library is available under the namespace System.Thrading.Tasks
// All threads in ThreadPool are background threads. The [Main] Thread will not wait for the background threads to completed, insteads it shall terminate as soon as its work is done.  
namespace SampleConApp
{
    internal class Ex22TaskProgramming
    {
        static async Task Main(string[] args)
        {
            //ThreadPoolExample();
            var rsult = await TaskProgrammingExample();
            Console.WriteLine("The Task programming gave the result as " + rsult);
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Some Work is running from Main");
            }
        }

        private static async Task<int> TaskProgrammingExample()
        {
            int value = 0;
            await Task.Run(() =>
            {
                for(int i = 0; i < 10; i++)
                {
                    value += i;
                    Thread.Sleep(1000);
                    Console.WriteLine($"Some Task is running for the index {i}");
                }
            });
            return value;
        }

        private static void ThreadPoolExample()
        {
            int workerThreadCount, processCounts;
            ThreadPool.GetMaxThreads(out workerThreadCount, out processCounts);
            Console.WriteLine($"The Count of Threads in current thread pool is {workerThreadCount}");
        }
    }
}
