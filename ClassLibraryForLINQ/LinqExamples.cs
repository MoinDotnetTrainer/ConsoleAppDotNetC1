using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForLINQ
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    public class LinqExamples
    {
        public static void Ex()
        {
            int[] arr = { 23, 34, 45, 5, 667, 23, 34, 45, 5, 667, 6, 8678, 7, 978, 97, 9890, 08, 0 };

            List<int> list = new List<int>() { 5, 56, 7, 567, 8, 67, 68, 7, 978, 97, 9890, 08, 0 };

            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "John",Email="john@yahoo.com", Age = 20, City = "New York" },
                new Student { Id = 2, Name = "Alice",Email="Alice@yahoo.com",  Age = 22, City = "Los Angeles" },
                new Student { Id = 3, Name = "Bob",Email="Bob@yahoo.com",  Age = 19, City = "Chicago" },

                new Student { Id = 4, Name = "Eve",Email="Eve@yahoo.com",  Age = 21, City = "Houston" },
             new Student { Id = 1, Name = "John",Email="john@yahoo.com", Age = 20, City = "New York" },
                new Student { Id = 2, Name = "Alice",Email="Alice@yahoo.com",  Age = 22, City = "Los Angeles" },
                new Student { Id = 3, Name = "Bob",Email="Bob@yahoo.com",  Age = 19, City = "Chicago" },
                new Student { Id = 4, Name = "Eve",Email="Eve@yahoo.com",  Age = 221, City = "Houston" }


            };

            List<Student> students1 = new List<Student>()
            {
                new Student { Id = 1, Name = "John",Email="john@yahoo.com", Age = 20, City = "New York" },
                new Student { Id = 2, Name = "Alice",Email="Alice@yahoo.com",  Age = 22, City = "Los Angeles" },
                new Student { Id = 3, Name = "Bob",Email="Bob@yahoo.com",  Age = 19, City = "Chicago" },

                new Student { Id = 4, Name = "Eve",Email="Eve@yahoo.com",  Age = 21, City = "Houston" },
             new Student { Id = 1, Name = "John",Email="john@yahoo.com", Age = 20, City = "New York" },
                new Student { Id = 5, Name = "Alice",Email="Alice@yahoo.com",  Age = 22, City = "Los Angeles" },
                new Student { Id = 3, Name = "Bob",Email="Bob@yahoo.com",  Age = 19, City = "Chicago" },
                new Student { Id = 4, Name = "Eve",Email="Eve@yahoo.com",  Age = 221, City = "Houston" }


            };


            var methodsyntax = students.Where(x => x.Age > 50).ToList();



            // LINQ syntax to fetch the data from array

            var result = from s in arr select s;

            var res1 = from s in arr where s > 50 select s;

            var res2 = from s in students where s.Age > 20 select s;

            var res3 = from s in students where s.City == "Chicago" select s;

            var res4 = from s in students where s.Name == "John" && s.Email == "john@gamil.com" select s;

            var res5 = from s in students
                       select new Student
                       {
                           Id = s.Id,
                           Name = s.Name
                       };


            var res6 = from s in students where s.Age > 20 select s;


            var specific = from s in students
                           select new Student
                           {
                               Id = s.Id,
                               Name = s.Name
                           };
            foreach (var item in specific)
            {

                // Console.WriteLine($"ID is {item.Id} name is {item.Name} email is {item.Email} Age is {item.Age} city {item.City} ");
            }

            object[] obj = { 123, true, "Hi", "hello", true, 2343.345, 34, 4 };

            var offtype = obj.OfType<bool>().ToList();

            foreach (var item in offtype)
            {
                //Console.WriteLine(item);
            }


            int[] arr1 = { 23, 49, 34, 45, 5, 667, 23, 34, 45, 55, 55, 5, 667, 6, 8678, 7, 978, 97, 9890, 08, 0 };


            var duplicate = (from s in arr1 select s).Distinct();
            var dup = (from s in arr1 select s).DistinctBy(x => x > 50).ToList();
            var std = (from s in students select s).DistinctBy(students => students.Id).ToList();


            //max maxby , min miny

            var max1 = arr1.Max(); // method syntax
            var dis = arr1.Distinct();
            foreach (var item in duplicate)
            {
                // Console.WriteLine(item);
            }



            var max = (from s in arr1 select s).Max(); // query syntax
            var maxby = (from s in students select s).MaxBy(x => x.Age);
            // Console.WriteLine(maxby.Age);


            // result merge

            int[] source1 = { 123321, 23, 49, 34, 45, 5, 667, 23, 34, 45, 55, 55, 5, 667, 6, 8678, 7, 978, 97, 9890, 08, 0 };
            int[] source2 = { 3, 3456, 456, 567, 56, 5, 5, 667, 6, 8678, 7, 978, 97, 9890, 08, 0 };

            // union ,concatenate, intersect, except
            // 
            var unionMethod = source1.Union(source2).ToList();
            var unionQuery = (from s in source1 select s).Union(source2).ToList();
            var concatQuery = (from s in source1 select s).Concat(source2).ToList();


            var intersectQuery = (from s in source1 select s).Intersect(source2).ToList();

            var exceptQuery = (from s in source1 select s).Except(source2).ToList();

            foreach (var item in exceptQuery)
            {
                // Console.WriteLine(  item);
            }


            var stdunion = students.UnionBy(students1, x => x.Id).ToList();

            foreach (var item in stdunion)
            {
                //  Console.WriteLine(  item.Id);
            }



            // All Any Contains (T/F)
            int[] data = { 234, 5, 34, 545, 6, 657, 5686, 78, 9, 879, 790, 980, 0 };
            var allex = (from s in data select s).All(x => x >= 0);
            var anyex = (from s in data select s).Any(x => x > 10);
            // Console.WriteLine(anyex);

            List<Student> data1 = new List<Student>()
            {
                new Student { Id = 1, Name = "John",Email="john@yahoo.com", Age = 20, City = "New York" },
                new Student { Id = 2, Name = "Alice",Email="Alice@yahoo.com",  Age = 22, City = "Los Angeles" },
                new Student { Id = 3, Name = "Bob",Email="Bob@yahoo.com",  Age = 19, City = "Chicago" },
            };

            var firstex = (from s in data1 select s).FirstOrDefault(x => x.Age > 20);
            // Console.WriteLine(firstex.Id); //

            var allex1 = (from s in data1 select s).All(x => x.Age >= 20);

            var allex2 = (from s in data1 select s).Any(x => x.Name == "John" && x.Email == "john@yahoo.com");


            var contains = (from s in data select s).Contains(324);
            //  Console.WriteLine(contains);

            int[] mydata = { 234, 234, 35, 6, 456, 500, 46, 7 };


            //var ele = (from s in mydata select s).ElementAt(10);
            //var eleordef = (from s in mydata select s).ElementAtOrDefault(100);

            //var first = (from s in mydata select s).First();
            //var firstdef = (from s in mydata select s).FirstOrDefault(x => x > 1000);

            //var last = (from s in mydata select s).Last();
            //var lastdef = (from s in mydata select s).LastOrDefault(x => x > 10);


            // var single = (from s in mydata select s).SingleOrDefault(x => x > 400);

            //  Console.WriteLine(single);


            int[] mydata1 = { 234, 234, 35, 63, 456, 500, 46, 7 };
            var take = (from s in mydata1 select s).Take(3);
            var takewhile = (from s in mydata1 select s).TakeWhile(x => x > 30);


            var skip = (from s in mydata1 select s).Skip(3);
            var skipwhile = (from s in mydata1 select s).SkipWhile(x => x>10);
            // til the cond is true
            foreach (var item in skipwhile)
            {
                Console.WriteLine(item);
            }
        }
    }
}
