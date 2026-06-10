using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//In Functions, we can have paramters that can be passed by reference. 

namespace SampleConApp
{
    internal class Ex07OutRefParameters
    {

        static void TestFunc(ref int iVal)//As if the function is giving a value. 
        {
            iVal = 123; //changes made inside the function is limited to the function only. 
            Console.WriteLine("The iVal: " + iVal);
        }

        //Function that returns added, subtracted, multiplied and divided value:
        static void MathFunc(double v1, double v2, out double sum, out double diff, out double product, out double quotent)
        {
            sum = v1 + v2;
            diff = v1 - v2;
            product = v1 * v2;
            if(v2 != 0)
                quotent = v1 / v2;
            else
                quotent = 0;
        }

        static (double, double, double, double) NewMathFunc(double v1, double v2)
        {
            var sum = v1 + v2;
            var diff = v1 - v2;
            var product = v1 * v2;
            var quotent = v1 / v2;
            return (sum, diff, product, quotent);
        }

        //Params keyword is used with array only. 
        //There can be only 1 params type per function. 
        //Params should be the last of the parameter list. 
        //Cant use params with ref and out keywords. 
        static double ParamsExample(params double[] numbers)
        {
            double result = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
        static void DivideFunc(double v1, double v2, out double result)
        {
            if(v2 == 0)
            {
                result = 0;
            }
            else
            {
                result = v1 / v2;
            }
        }

        static void Main(string[] args)
        {
            //int iVal = 234;//U must initialze the value before U pass to the function. 
            //Console.WriteLine("The Value before passing to the function: " + iVal);
            //TestFunc(ref iVal);
            //Console.WriteLine("The value after passing to the function: " + iVal);


            //double res;//out paramaters give the value, U dont have to initialise. 
            //DivideFunc(123, 3, out res);
            //Console.WriteLine("The Divided value is " + res);


            double sum, diff, product, quotent;
            MathFunc(12,3, out sum, out diff, out product, out quotent);
            Console.WriteLine($"The Added value : {sum}\nThe Subtracted value: {diff}\nThe Multiplied Value: {product}\nThe Divided Value: {quotent}");

            var results = NewMathFunc(12, 3);
            Console.WriteLine($"The Added value : {results.Item1}\nThe Subtracted value: {results.Item2}\nThe Multiplied Value: {results.Item3}\nThe Divided Value: {results.Item4}");


            //Calling Params
            var result = ParamsExample(12, 23, 34, 45, 56, 6, 64, 3, 456, 233);
        }
    }
}
