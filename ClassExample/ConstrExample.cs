using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class ConstrExample
    {
        // method , name UD  , object
        // static method , User dfine , class name
        // Constructor Method , no return type
        // auto on object creation

        public ConstrExample()  // default , implict
        {
            Console.WriteLine("this is my constr execution");
        }
        public ConstrExample(int x)  // parameterized , or explict
        {
            Console.WriteLine("int task");
        }

        public ConstrExample(int x, string y)
        {
            Console.WriteLine("int ,str task");
        }

        public ConstrExample(string x)
        {
            Console.WriteLine("str task");
        }
    }
}
