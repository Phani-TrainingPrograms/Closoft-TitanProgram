using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Class is a user defined type that represents real world entity. It can contain fields, properties, functions and events. 
//Fields are data that are hidden from the outside world. User who consumes the class is usually not seeing this data. 
//Functions or methods are used to read/write/compute the data. 
//properties are new in C# which represents getters and setters to the fields. 
//Class is more like declaration, the usage happens thru objects. objects are variables(instances) of that class.
//objects in C# are created using new operator
namespace SampleConApp
{
    //old C# code similar to C++...
    class Data
    {
        int id;
        string someInfo;
        string anotherInfo;
        DateTime date;

        public void SetId(int id) => this.id = id;//this represents the object. 

        public void SetSomeInfo(string info) => this.someInfo = info;
        public void SetAnotherInfo(string info) => this.anotherInfo = info;

        public void SetDate(DateTime date) => this.date = date;
        public int GetId() => this.id;
        public string GetSomeInfo() => this.someInfo;
        public string GetAnotherInfo() => this.anotherInfo;

        public DateTime GetDate() => this.date;

    }

    class NewData
    {
        //properties are accessors to the hidden private data of UR class. 
        public int ID { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoin { get; set; }
    }
    internal class Ex14ClassesAndObjecs
    {
        static void Main(string[] args)
        {
            Data obj = new Data();//syntax....
            obj.SetId(123);
            obj.SetAnotherInfo("Personal Info");
            obj.SetSomeInfo("Basic Info");
            obj.SetDate(new DateTime(2026, 4, 23));

            Console.WriteLine($"The Info about the obj is {obj.GetId()}, {obj.GetSomeInfo()},{obj.GetAnotherInfo()},{obj.GetDate()}");

            /////object with new Syntax
            ///
            var obj2 = new NewData { DateOfJoin = DateTime.Now, Description = "Small info about the product", Name = "Name for this Product", ID = 123 };

            Console.WriteLine($"The Info about the obj2 is {obj2.ID}, {obj2.Name},{obj2.Description},{obj2.DateOfJoin}");

        }
    }

}
//todo: Create a class called Expense, its data includes: id, description, date, amount. 
//Provide properties to it and create an object of the Expense and take inputs from the user and display the Expense details on the Console. 



