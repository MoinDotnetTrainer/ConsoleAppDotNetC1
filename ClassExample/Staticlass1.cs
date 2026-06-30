using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public static class Staticlass1
    {
        static Staticlass1()
        { // default
            Console.WriteLine("Static constr");
        }
        
        public static void M1()
        {
            Console.WriteLine("m1");
        }

        public static void M2()
        {   // object
            Console.WriteLine("m2");
        }
    }
}
