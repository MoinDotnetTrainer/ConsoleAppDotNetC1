using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Parent
    {
        protected int x, y, z;

        public Parent() {
            Console.WriteLine("Constr");
        }
        protected void Add()
        {
            x = 5;
            y = 4;
            z = x + y;
            Console.WriteLine("Add is :" + z);
        }
        public void Sub()
        {
            x = 5;
            y = 4;
            z = x - y;
            Console.WriteLine("Sub is :" + z);
        }
    }

   public class Child : Parent
    {
        
        public void Mul()
        {
            Add();
          //  Sub();
            x = 5;
            y = 4;
            z = x * y;
            Console.WriteLine("Mul is :" + z);
        }
        public void Div()
        {
            x = 5;
            y = 4;
            z = x / y;
            Console.WriteLine("Div is :" + z);
        }
    }

    public class Child1 : Parent
    {

        public void Mul()
        {
            //   Add();
            //  Sub();
            x = 5;
            y = 4;
            z = x * y;
            Console.WriteLine("Mul is :" + z);
        }
        public void Div()
        {
            x = 5;
            y = 4;
            z = x / y;
            Console.WriteLine("Div is :" + z);
        }
    }
}
