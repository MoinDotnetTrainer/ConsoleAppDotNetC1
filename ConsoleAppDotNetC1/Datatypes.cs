using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDotNetC1
{
    internal class Datatypes
    {
        public void ExDatatypes()
        {
            // Integer
            // byte short int long  
            // 1 byte 2 byte 4 8

            // byte 0-255
            // byte sbyte

            byte b = 255;  // no error unsigned  +
            sbyte sb = 127;  //--> signed -+

            short s = 234;
            ushort us = 34;

            int i = 345;
            uint ui = 45;


            long l = 46;
            ulong ul = 34;

            float f = 34.54f;
            double d = 435.34;
            decimal dm = 35.56m;

            char c = 'A';

            string str = "Hello world";

            bool status = false;

            Console.WriteLine(status);

            //compile time
            var v1 = 234;
            v1 = 34;
            v1 = 345;
            //v1 = true;//error here
            var v2 = "hello";
            var v3 = true;
            var v4 = 34.45;
            var v5 = 43556;


            //runtime
            dynamic d1 = 234;
            d1 = 3.4;
            d1 = "hi";
            dynamic d2 = "hello";
            dynamic d3 = true;
            dynamic d4 = 34;
            dynamic d5 = 43556;

            Console.WriteLine(v1);
            Console.WriteLine(d1);


            //value
            dynamic resilt = d1 + d4;


            //run time
            object o1 = 45;
            o1 = 213;
            o1 = true;
            object o2 = 34.45;
            object o3 = "test";

            // reference type
            // u need to convert ref to value
            object res = (int)o1 + (int)o2;




        }
    }
}
