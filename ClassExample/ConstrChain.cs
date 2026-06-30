using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class ConstrChain
    {
        public ConstrChain():this("hi") {
            Console.WriteLine(" def constr");
        }

        public ConstrChain(int x) : this(12,"hi")
        {
            Console.WriteLine(" int constr");
        }

        public ConstrChain(string y): this(23)
        {
            Console.WriteLine(" str constr");
        }

        public ConstrChain(int x,string y)
        {
            Console.WriteLine("int str constr");
        }
    }
    public class ChildClass : ConstrChain
    {
        public ChildClass():base(23) {
            Console.WriteLine("This is child def constr");
        }
    }
}
