using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class GP
    {
        public int x, y, z;
    }

    public class P : GP
    {
        public void Add() {
            x = 46;
        }
    }

    public class Siblings : P
    {
        public void Sub(){
            x = 345;
        }
    }
}
