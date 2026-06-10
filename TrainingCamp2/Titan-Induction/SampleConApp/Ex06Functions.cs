using System;

//Functions are a group of statements that are executed frequently within the Application.
//Functions are created for modularity and maintainability purposes. 
//Functions can take inputs(parameters) and might give you outputs(Return values). 
//Parameters can be in(Default), ref, out, params.
//Functions cannot be created as global. They are always a part of class. 
//You create object of the class and invoke the function thru that object. 
//Alternatively, U can make the function as static(Singleton) and invoke them using the classname instead of object. 
namespace SampleConApp
{
    class MathClass
    {
        public void AddFunction()
        {
            Console.WriteLine("Enter the First Value");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second Value");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Added value is {v1 + v2}"); 
        }

        public double AddFunc(double v1, double v2) => v1 + v2;

        //todo: Create Additional functions to subtract, multiply and divide. Call them in the Main program. 
    }

    class Validator
    {
        public static bool ValidatePositiveNumber(double no)
        {
            if(no < 0) return false;
            else 
                return true;
        }
    }
    internal class Ex06Functions
    {
        static void Main(string[] args)
        {
        input1:
            Console.WriteLine("Enter the First Value");
            double v1 = Convert.ToDouble(Console.ReadLine());

            var validate = Validator.ValidatePositiveNumber(v1);//Static function, we are not creating the object. 
            if(!validate)
            {
                Console.WriteLine("User must enter a +ve number");
                goto input1;
                //return;//Jump statement that exits the block. 
            }
        Input2:
            Console.WriteLine("Enter the Second Value");
            double v2 = Convert.ToDouble(Console.ReadLine());
            validate = Validator.ValidatePositiveNumber(v2);
            if(!validate)
            {
                Console.WriteLine("User must enter a +ve number");
                goto Input2;
                //return;//Jump statement that exits the block. 
            }

            //validation is complete...
            MathClass cls =new MathClass();//create the object of the class
            var result = cls.AddFunc(v1, v2);//call the functio thru the object using . operator. 

            Console.WriteLine($"The result of this operation is  {result}");
        }
    }
}
