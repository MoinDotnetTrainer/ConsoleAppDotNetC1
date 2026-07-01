using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void CallingDel();
public delegate int CallingDel1(int x);

namespace ClassExample
{
    public class DelegatesEx
    {
        public void Task() {
            Console.WriteLine("one line of Code");
        }

        public int Return() {
            return 1;
        }

        public bool Check() {
            return true;
        }   
    }
}
