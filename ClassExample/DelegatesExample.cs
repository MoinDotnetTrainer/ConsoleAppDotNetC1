using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void MyDelegate1();
public delegate int MyDelegate2(int x, int y);
namespace ClassExample
{
    public class DelegatesExample
    {
        public void Add()
        {
            int x = 35, y = 45, z;
            z = x + y;
            Console.WriteLine("Add is:" + z);
        }
        public void Sub()
        {
            int x = 35, y = 45, z;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }


        public int Mul(int x, int y)
        {
            int z;
            z = x * y;
            Console.WriteLine("Mul is:" + z);
            return z;
        }
        public int Div(int x, int y)
        {
            int z;
            z = x / y;
            Console.WriteLine("Div is:" + z);
            return z;
        }

        public int fact(int x, int y)
        {
            int z;
            z = x % y;
            Console.WriteLine("Fact is:" + z);
            return z;
        }
    }
}
