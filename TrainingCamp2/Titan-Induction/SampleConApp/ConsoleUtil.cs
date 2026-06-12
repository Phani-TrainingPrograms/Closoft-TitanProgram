using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal static class ConsoleUtil
    {
        public static int GetNumber(string question)
        {
            Console.WriteLine(question);
            int no;
            if(!int.TryParse(Console.ReadLine(), out no))
            {
                Console.WriteLine("Input was wrong");
                no = 0;
            }
            return no;
        }

        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static double GetDouble(string question)
        {
            double val;
        TRYAGAIN:
            if(double.TryParse(Console.ReadLine(), out val))
            {
                return val;
            }
            Console.WriteLine("Invalid value");
            goto TRYAGAIN;
        }

        public static DateTime GetDate(string question)
        {
            DateTime val;
        TRYAGAIN:
            if(DateTime.TryParse(Console.ReadLine(), out val))
            {
                return val;
            }
            Console.WriteLine("Invalid date");
            goto TRYAGAIN;
        }
    }
}
