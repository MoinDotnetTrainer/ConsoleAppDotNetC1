using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDotNetC1
{
    internal class Readline
    {
        public void Test()
        {
            Console.WriteLine(" Enter Ur name!");
            string Uname = Console.ReadLine();  // scanf , value at runtime
            Console.WriteLine($" Name is {Uname}");

            Console.WriteLine("Enter ur name");
            byte Age = Convert.ToByte(Console.ReadLine());  //35 o/p of readline isin string 23 ==> "23"
            Console.WriteLine($" Age is {Age}");

            Console.WriteLine("Enter ur Salary");
            float sal = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($" Sal is {sal}");
            // LHS == RHS type
            // type casting

            // Parsing tech
        }
    }
}
