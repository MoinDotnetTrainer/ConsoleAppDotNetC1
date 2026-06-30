using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class ConstrReadonly
    {
        // int byte char arr string
        // var dynamic object

        int x;
        string y;
        int[] arr;
        int? x1;
        //  var x2;
        dynamic d1;
        object o1;

        const int pi = 90;
        readonly int pi1;

        public ConstrReadonly()
        {
            x = 436;
            Console.WriteLine(pi);
            const int a = 45;
            pi1 = 4;
        }
        public void M1()
        {
            var gfgh = 45;
            x = 2435;

            const int a1 = 45;
            //  pi1 = 34;


            Console.WriteLine(" M1 executing from ConstrReadonly ");
        }

        public void M2(dynamic x)
        {
            x = 3456;
          //  pi = 56;
        }

        public void M3(object x)
        {

        }

        public void test() {
            Console.WriteLine("test exe");
        }
    }
}
