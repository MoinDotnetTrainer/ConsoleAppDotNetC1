using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class refout
    {
        public static void Call(ref int x)  // x=10
        {
            Console.WriteLine("Before Cal :" + x);  // 10
            x = x + 10;  // 20

            // x addreess is : 12345 --> 121212  --> 10
            Console.WriteLine("After cal :" + x);// 20
        }
        public static void Exe()
        {
            int y = 10;
            Console.WriteLine("Y before passing :" + y);  // y : 10

            Call(ref y);  // pass the value of y , call by ref

            // y = 121212 : 10

            Console.WriteLine("Y after call:" + y);  // y : 20
        }
    }
}
