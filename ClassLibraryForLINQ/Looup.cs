using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForLINQ
{
    public class Lookup
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


            var groupby = from s in students1 group s by s.City;

            var Looup = (from std in students1
                         select std).ToLookup(x => x.Age);
            students1.Add(new Student { Id = 9, Name = "xyz", Email = "xyz@yahoo.com", Age = 44, City = "Houston" });

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
        }

        public static void T1()
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

            IEnumerable<Student> data = from s in students1 where s.Age > 20 select s;


            IQueryable<Student> data1 = (from s in students1 where s.Age > 20 select s).AsQueryable();


            foreach (var item in data)
            {
               Console.WriteLine($"Ienum ID is {item.Id} name is {item.Name} email is {item.Email} Age is {item.Age} city {item.City} ");
            }

            foreach (var item in data1)
            {
                Console.WriteLine($"Iquer ID is {item.Id} name is {item.Name} email is {item.Email} Age is {item.Age} city {item.City} ");
            }

        }
    }
}