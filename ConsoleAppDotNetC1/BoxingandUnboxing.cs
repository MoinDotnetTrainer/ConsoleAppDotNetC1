using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDotNetC1
{
    internal class BoxingandUnboxing
    {
        public void Test()
        {
            // value type
            // whose len is fixed
            // reference type
            // len is dynamic

            //int short byte float double decimal-- value
            // string array object  -- ref


            //value t ref
            // boxing , implict (auto)
            int x = 45;
            object o = x; // boxing
            Console.WriteLine(o.GetType());
            string str = x.ToString();// boxing


            // ref to value
            int x1 = (int)o; // unboxing , explict(manually)

            //value stack memory allo & heap ref memory allocation


            // implct an  explict
            //lower to heigher implicy
            // higher to lower explict

            byte b = 34;
            int x2 = b;  // implict 
            sbyte d = (sbyte)x2;  // higher to lower , loss of data

        }
    }
}
