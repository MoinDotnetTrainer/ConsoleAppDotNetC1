using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class ReturnType
    {
        public  void Add()  // static
        {
            int x = 50, y = 50, z;
            z = x + y;
            Console.WriteLine("Add is :" + z);
        }

        public static int Sub()
        {
            int x = 50, y = 50, z;
            z = x - y;
            Console.WriteLine("sub is :" + z);
            return z;
        }

        public string str()
        {
            return "hi";
        }

        public float f1()
        {
            return 23.35f;
        }

        public char ch()
        {
            return 'a';
        }

        public (int, string) M1()
        {
            return (12, "hi");
        }


        public (int, string, bool) M2() {
            return (1,"xyz",true);
        }
    }
}
