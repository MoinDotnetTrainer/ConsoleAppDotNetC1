using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForLINQ
{
    public class Linq
    {
        public static void test()
        {
            List<Student> students1 = new List<Student>()
            {
                new Student { Id = 1, Name = "John",Email="john@yahoo.com", Age = 26, City = "New York" },
                new Student { Id = 2, Name = "Alice",Email="Alice@yahoo.com",  Age = 34, City = "Los Angeles" },
                new Student { Id = 3, Name = "Bob",Email="Bob@yahoo.com",  Age = 19, City = "Chicago" },
                new Student { Id = 4, Name = "Eve",Email="Eve@yahoo.com",  Age = 21, City = "Houston" },
                new Student { Id = 5, Name = "John1",Email="john@yahoo.com", Age = 28, City = "New York" },
                new Student { Id = 6, Name = "Alice",Email="Alice@yahoo.com",  Age = 12, City = "Los Angeles" },
                new Student { Id = 7, Name = "Bob",Email="Bob@yahoo.com",  Age = 19, City = "Chicago" },
                new Student { Id = 8, Name = "Eve",Email="Eve@yahoo.com",  Age = 221, City = "Houston" }

                // order by used to sort in asc or desc

            };


            var groupby = from s in students1 group s by s.City ;

            var Looup = (from std in students1
                         select std).ToLookup(x => x.Age);

            // age key 
            Console.WriteLine("group by");
            foreach (var item in groupby)
            {
                Console.WriteLine(item.Key);
                foreach (var data in item)
                {
                    Console.WriteLine(data.Id + " " + data.Name + " " + data.Age);

                }
            }


            Console.WriteLine("Loop up");
            foreach (var item in Looup)
            {
                Console.WriteLine(item.Key);
                foreach (var data in item)
                {
                    Console.WriteLine(data.Id + " " + data.Name + " " + data.Age);

                }
            }

            var lazy = from s in students1 where s.Age > 25 select s;  // 5 employyee
            var imme = (from s in students1 where s.Age > 25 select s).Count();   // 4 already atared and ends

            students1.Add(new Student { Id = 9, Name = "xyz", Email = "xyz@yahoo.com", Age = 44, City = "Houston" });


            var res = from s in students1 orderby s.Age descending select s;

            // then by 


            var thenby = students1.OrderBy(x => x.Name).
                ThenByDescending(x => x.Age).
                ThenByDescending(x => x.Id).
                ToList();


            foreach (var item in lazy)  // making a call
            {
               // Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
            }

           // Console.WriteLine(imme);// 
        }
    }
}
