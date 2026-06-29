using ClassExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDotNetC1
{
    internal class Parsing
    {
        public void test()
        {
            //string str = null;
            //int x = Convert.ToInt32(str);  //0
            //Console.WriteLine(x);

            //string str1 = null;// try parse
            //int x1 = int.Parse(str1);  // error , will not accept null value
            //Console.WriteLine(x1);

            ReturnType r = new ReturnType();
            r.Add();  //new memory

            string Uname = null;

            if (int.TryParse(Uname, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No res");
            }
        }
    }
}
