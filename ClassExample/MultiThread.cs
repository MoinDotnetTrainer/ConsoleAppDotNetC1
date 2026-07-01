using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class MultiThread
    {
        public static void M1() { 
        for (int i = 0; i < 10; i++)
            {
               
                Console.WriteLine("M1 Thread");
            }   
        }

        public static void M2()
        {
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("M2 Thread");
            }
        }
    }
}
