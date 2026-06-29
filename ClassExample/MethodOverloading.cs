using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class MethodOverloading
    {
        public static void M1() {
            Console.WriteLine(" task 1");
        }
        public static void M1(int x)
        {
            Console.WriteLine(" task 2");
        }
        public static void M1(double x)
        {
            Console.WriteLine(" task 2");
        }
        public static void M1(string str)
        {
            Console.WriteLine(" task 3");
        }
        public static void M1(int x , int y)
        {
            Console.WriteLine(" task 4");
        }
        public static void M1(int x, string y)
        {
            Console.WriteLine(" task 5");
        }
        public static void M1(string x, int y)
        {
            Console.WriteLine(" task 6");
        }

    }
}
