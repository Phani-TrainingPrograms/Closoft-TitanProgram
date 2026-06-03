//namespace is used to create extra grouping to avoid naming conflicts.
//Namespace does not allocate any memory. Its only conceptual in nature. 
//U refer the class of the namespace either by using fully qualified name or use the using
using System;
using LivingThings;
using MoralScience;
namespace LivingThings
{
    class Fruit
    {

    }
}

namespace MoralScience
{
    class Fruit
    {

    }
}

class MainProgram
{
    static void Main(string[] args)
    {
        MoralScience.Fruit fs = new MoralScience.Fruit();
        LivingThings.Fruit fs2 = new LivingThings.Fruit();

        Console.WriteLine("Testing code");
    }   
}