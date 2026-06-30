using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public static class Props
    {

        public static int ID { get; set; }

        public static string Name { get; set; }
        // static int x, y, z;

        // to acccess private variable within we make use of properties

        // var are having  addreess nd a sen info

        private static int x;
        public static int x_
        {
            get { return x; }
            set
            {
                if (value > 50)
                {
                    throw new ArgumentException("Value cannot more then 50");
                }
                else
                {
                    x = value;
                }

            }
        }

        private static int y;

        public static int y_
        {
            get { return y; }
            set
            {
                if (value > 50)
                {
                    throw new ArgumentException("Value cannot more then 50");
                }
                else
                {
                    y = value;
                }
            }
        }


        public static void Add()
        {
            int z = x + y;  // x = 50 , y =50 z= 100
            Console.WriteLine("Add is:" + z);
        }
    }
}
