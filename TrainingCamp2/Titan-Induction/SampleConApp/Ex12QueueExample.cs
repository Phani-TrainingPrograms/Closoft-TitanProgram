using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Queue is a collection to store data as FIFO. 
//Widely used in E-commerce apps that allows user to see his/her last few transactions/viewed items
namespace SampleConApp
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    internal class Ex12QueueExample
    {
        static Queue<Product> viewedItems = new Queue<Product>();

        static void ViewItem(int id, string name, int price)
        {
            if(viewedItems.Count == 5)
            {
                viewedItems.Dequeue();
            }
            viewedItems.Enqueue(new Product { Id = id, Name = name, Price = price });//Add to the Queue
            Console.WriteLine("Current Item viewed: " + name);
        }

        static void DisplayRecentlyViewedItems()
        {
            var recentItems = viewedItems.Reverse ();
            foreach(var item in recentItems)
            {
                Console.WriteLine("Item: " + item.Name);
                Console.WriteLine("Item Price: " + item.Price);
                Console.WriteLine("\n\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FlipKart");
            ViewItem(1, "Apples", 200);
            ViewItem(2, "AppleiPhone", 200);
            ViewItem(3, "Samsung phone", 200);
            ViewItem(4, "Nokia Phone", 200);
            ViewItem(5, "Lunar Bag", 200);
            DisplayRecentlyViewedItems();
            ViewItem(6, "TestItem", 500);
            DisplayRecentlyViewedItems();//1st item is gone and last item is added
            ViewItem(7, "Titan watch", 5600);
            DisplayRecentlyViewedItems();
        }
    }
}
