using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public static class GenMethod
    {
        public static void Test(int x, int y)
        {  // datatype as an argument
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        //gen method , type as an argument

        public static void Test1<type1>(type1 x, type1 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public static void Test2<type1, type2>(type1 x, type2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
