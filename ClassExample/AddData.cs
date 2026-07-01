using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Std : IComparable<Std>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }

        public int CompareTo(Std other)
        {
            return this.Name.CompareTo(other.Name);   // Sort by ID
        }
    }
    public class AddData
    {
        public static void AddStdData()
        {


            SortedSet<Std> stdList = new SortedSet<Std>()
        {
            new Std { ID = 1, Name = "xyz Doe", Email = "xyz@yahoo.com", Status = true },
            new Std { ID = 3, Name = "abc Doe", Email = "abc@yahoo.com", Status = true },
            new Std { ID = 2, Name = "pqr Smith", Email = "pqr@yahoo.com", Status = false },
            new Std { ID = 4, Name = "test Smith", Email = "test@yahoo.com", Status = false }
        };

            foreach (var std in stdList)
            {
                Console.WriteLine($"ID: {std.ID}, Name: {std.Name}, Email: {std.Email}, Status: {std.Status}");
            }
        }
    }
}
