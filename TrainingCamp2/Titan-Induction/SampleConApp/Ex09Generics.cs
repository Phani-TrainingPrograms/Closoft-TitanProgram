using System;
using System.Collections.Generic;
using System.Runtime.InteropServices; //Contains the classes required for Collection classes and its generic. It could be applied on any kind of data types. 

//Arrays being fixed in size, its impratical to work on real time scenarios. 
//Collection classes are crearted to fill the gaps of Arrays. 
//List<T> is a generic class used to represent data of a certain data type<T>. List stores the data like an array, but dynamic. 
//Add Function used to add new element into the list to the bottom of the list. 
//List being a collection class, it can be used in a foreach statement.
//It hs functions to insert, remove, find, findAll, and sort along with many other features.
//no of elements can be obtained using Count property. 
//Create, Read, Update, Delete operations
namespace SampleConApp
{
    class StringRepo
    {
        static List<string> repo = new List<string>();

        public static List<string> GetAllRecords() => repo;
        
        public static void AddNewRecord(string rec) => repo.Add(rec);

        public static void UpdateRecord(int index, string newVal)
        {
            if(index < repo.Count || index > 0)
            {
                repo.RemoveAt(index);//delete the old value
                repo.Add(newVal);//insert the new value at that index. 
            }
        }

        public static void DeleteRecord(int index) => repo.RemoveAt(index);
    }
    internal class GenericsExample
    {
        static void Main(string[] args)
        {
            //simpleListExample();
            StringRepo.AddNewRecord("Apples");
            StringRepo.UpdateRecord(0, "Apples from Simla");
            var data = StringRepo.GetAllRecords();
            foreach(var rec in data)
                Console.WriteLine(rec);
        }

        private static void simpleListExample()
        {
            List<string> fruits = new List<string>();
            string input = "";
            do
            {
                Console.WriteLine("Enter the fruit name to add:");
                string fruit = Console.ReadLine();
                fruits.Add(fruit);
                Console.WriteLine("Press Y to add another fruit or N or any other charecter to exit");
                input = Console.ReadLine();
            } while(input.ToLower() == "y");

            Console.WriteLine("Exiting the input structure, lets read the data whose count is " + fruits.Count);
            foreach(var item in fruits)
            {
                Console.WriteLine(item);
            }
            fruits.Sort(); //IComparable. 
            Console.WriteLine("Fruits in sorted order:");
            foreach(var item in fruits)
            {
                Console.WriteLine(item);
            }
            //fruits.Insert(3, "PineApples");//Inserts only if the index is availble, else throws an Exception.
            //fruits.Remove("Apples");//true if the item is removed, else false. 
            var data = fruits.FindAll(f => f.ToLower().Contains("a"));//Lamdba Expressions.
            Console.WriteLine("Found list of fruits:");
            foreach(var item in data)
                Console.WriteLine(item);
        }
    }
}
