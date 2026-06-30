using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public abstract class Vehicle
    {
        public abstract void Break();  // signature , no Implementaion
        public abstract void Accelerate();

        public virtual void Music() { 
        
        }
        
        // are ment for overriding
    }

    public class BMWcar : Vehicle {
        public override void Break() {
            Console.WriteLine(" BMW Breaks");
        }  // signature , no Implementaion
        public override void Accelerate() {
            Console.WriteLine(" BMW accelerate");
        }

    }

    public class PulsarBike : Vehicle
    {
        public override void Break()
        {
            Console.WriteLine(" PulsarBike Breaks");
        }  // signature , no Implementaion
        public override void Accelerate()
        {
            Console.WriteLine(" PulsarBike accelerate");
        }

    }
}
