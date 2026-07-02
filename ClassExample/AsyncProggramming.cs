using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class AsyncProggramming
    {
        public static int Call(string Filename)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(Filename))
            {
                string data = reader.ReadToEnd();
                len = data.Length;
                Task.Delay(5000).Wait(); // Simulate a delay of 5 seconds   
            }
            return len;
        }
        public static void Exe()
        {
            string Filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\Myfile.txt";
            int finalcount = Call(Filename);

            //7 
            Console.WriteLine("Task 1");
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 3");
            Console.WriteLine("No of Words in the given file is:" + finalcount);
            Console.WriteLine("Task 4");
            Console.WriteLine("Task 5");
            Console.WriteLine("Task 6");
        }
        public static async Task<int> Call1(string Filename)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(Filename))
            {
                string data = await reader.ReadToEndAsync();
                len = data.Length;
                Task.Delay(5000).Wait(); // Simulate a delay of 5 seconds   
            }
            return len;
        }
        public static async void Exe1()
        {
            string Filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\Myfile.txt";
            Task<int> finalcount = Call1(Filename);

            //7 
            Console.WriteLine("Task 1");
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 3");
            int res = await finalcount;
            Console.WriteLine("No of Words in the given file is:" + res);
            Console.WriteLine("Task 4");
            Console.WriteLine("Task 5");
            Console.WriteLine("Task 6");
        }
    }
}
