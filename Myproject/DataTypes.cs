using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject
{
    public class DataTypes
    {
        public void Test() {
            Console.WriteLine("Enetr Name :");
            string name = Console.ReadLine();
            Console.WriteLine($" Name is {name}");

            Console.WriteLine("Enetr Age :");
            byte  Age =Convert.ToByte( Console.ReadLine());
            Console.WriteLine($" Age is {Age}");

            Console.WriteLine("Enetr Status :");
            bool status =Convert.ToBoolean( Console.ReadLine());
            Console.WriteLine($" Status is {status}");
        }
    }
}
