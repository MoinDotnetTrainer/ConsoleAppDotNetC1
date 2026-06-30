using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class OutKeyword
    {
        public void M1() {
            Console.WriteLine("M1");
        }

        public int M2() {
            return 1;
        }

        public (int, string) M3() {
            return (12,"HI");
        }

        // another way of returing multiple values from a mthod is out key

        public static void Cal(int x, int y ,out int Add,out int Sub) {
            Add = x + y;
            Sub = x - y;
        }
    }
}
