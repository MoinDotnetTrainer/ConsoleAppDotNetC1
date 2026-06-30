using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public sealed class DontInherit
    {
        public int x, y, z;
    }

    public class GetData : DontInherit
    {
        public int Add() {
            x = 435;y = 34;
            z = x + y;
            return z;
        }
    }
}
