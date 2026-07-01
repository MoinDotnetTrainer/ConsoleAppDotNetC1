using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class GenClass<type1>
    {
        public void Test1(type1 x)
        {
            Console.WriteLine(x);
        }

        public void Test2(type1 x, type1 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
