using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Sample
    {
        public void Add()
        {
            int x = 45, y = 45, z;
            z = x + y;
            Console.WriteLine($"Add is {z}");
        }

        public void Sub(int x, int y)
        {
            int z = x - y;
            Console.WriteLine($"sub is {z}");
        }

        public void Userdata(string Name, params string[] add)
        {
            Console.WriteLine(Name);

            Console.WriteLine(add[0]);
        }
    }
}
