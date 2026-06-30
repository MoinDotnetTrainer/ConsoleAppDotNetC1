using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public interface Interface1
    {
        void Add();  // overriding
    }
    public interface Interface2
    {
        void Sub();
    }

    public abstract class Interface3
    {
        public abstract void Mul();
    }

    class GetInterface : Interface3, Interface1, Interface2
    {
        public void Add()
        {
            Console.WriteLine("Add");
        }
        public void Sub()
        {
            Console.WriteLine("Sub");
        }
        public override void Mul()
        {
            Console.WriteLine("Mul");
        }
    }

}
