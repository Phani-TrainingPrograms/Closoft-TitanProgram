using System;

//Arrays in C# are reference types. They are used to store data of similar kind as a group. It holds the data as an unit and easily accessible. 
//Arrays are fixed in size, once created, U cannot resize the array. 
//Ways to copy arrays: 4: assignment, Clone, Copy and CopyTo

namespace SampleConApp
{
    internal class Ex08Arrays
    {
        static void Main(string[] args)
        {
           // simpleArrayExample();
            //To Explore: 2 Dimensional Array and Jagged Array(Array of Arrays). 
            copyingArrays(); 
            //Ctrl+. to extract a section of code into a function or to create to implement a new function. 
        }

        private static void copyingArrays()
        {
            var data = new int[] { 12, 23, 4, 567 }; //New syntax for arrays
            Console.WriteLine("The size: " + data.Length);

            var temp = data;
            var copy = (int[]) data.Clone();//Creates a new copy of elements. Use this function to replicate the array. returns an object. BOXED VALUE. 
            var arrayWithMoreElements = new int[copy.Length + 5];
            //Static function that takes 2 arrays(Source and destination) and allows to copy the elements from a position to a fixed count. 
            Array.Copy(copy, 2, arrayWithMoreElements, 1, 2);
            foreach(var element in arrayWithMoreElements)
            {
                Console.WriteLine(element);
            }

            copy.CopyTo(arrayWithMoreElements, 4);//Copies the currernt object to the destination with size. 
            foreach(var element in arrayWithMoreElements)
            {
                Console.WriteLine(element);
            }
        }

        private static void simpleArrayExample()
        {
            //dataType [] identifier = new dataType[size];
            Console.WriteLine("Enter the size U want to create");
            int size = int.Parse(Console.ReadLine());
            string[] fruits = new string[size];
            //each element in the array is refered using [] operator with index in it. index starts with 0. 
            //fruits[0] = "Apples";
            //fruits[1] = "Mangoes";
            //fruits[2] = "Oranges";
            //fruits[3] = "Kiwi Fruit";
            for(int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"Enter the name of the fruit at index {i}");
                fruits[i] = Console.ReadLine();
            }
            Console.WriteLine("All valus are set, now lets read the data");
            //Read the values of the elements using for, foreach loops. 
            //If U want to read all the values of the array U can use for...each
            foreach(string value in fruits)//dont need the size, always within the bounds of the array.
            {
                Console.WriteLine(value);
            }
        }
    }
}
