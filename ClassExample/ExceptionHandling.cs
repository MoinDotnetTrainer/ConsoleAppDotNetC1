using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class ExceptionHandling
    {
        public static void Div()
        {
        a:
            try
            {
                Console.WriteLine("try Exe...");
                Console.WriteLine("Enter X:");
                int x = Convert.ToInt32(Console.ReadLine());  // runtime string
                Console.WriteLine("Enter Y:");
                int y = Convert.ToInt32(Console.ReadLine());  // run time

                int z = x / y; // runtime  , y=0

                int[] arr = { 123 };
                Console.WriteLine(arr[10]);  // index out of bound
                Console.WriteLine("Div is :" + z);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Plz Enter Only Number :" + ex.Message);
                goto a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Y cannot be zero :" + ex.Message);
                goto a;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("No Element Found :" + ex.Message);
                goto a;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Plz Enter Only Number :" + ex.Message);
                goto a;
            }
           

        }

        public static void Div1()
        {
        a:
            try
            {
                Console.WriteLine("try Exe...");
                Console.WriteLine("Enter X:");
                int x = Convert.ToInt32(Console.ReadLine());  // runtime string
                Console.WriteLine("Enter Y:");
                int y = Convert.ToInt32(Console.ReadLine());  // run time

                int z = x / y; // runtime  , y=0

                int[] arr = { 123 };
                Console.WriteLine(arr[10]);  // index out of bound
                Console.WriteLine("Div is :" + z);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Plz Enter Only Number :" + ex.Message);
                goto a;
            }



        }
    }
}
