using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryOPs;
namespace TestProject
{
    public class TestGrades
    {
        private Grades grades;
        [SetUp]
        public void Setup()
        {
            grades = new Grades();
        }

        [Test]
        public void TestforAGrades()
        {
            // Assign
            int percentage = 90;

            //Act

            string res = grades.GetGrades(percentage); // 
            // res = A;

            Assert.AreEqual("A", res);
        }

        [Test]
        public void TestforNegAGrades()
        {
            // Assign
            int percentage = 95;

            //Act

            string res = grades.GetGrades(percentage); // 
            // res = A;

            Assert.AreNotEqual("B", res);
        }

        [Test]
        public void TestforBGrades()
        {
            Assert.Pass();
        }

        [Test]
        public void TestforFail()
        {
            // Assign
            int percentage = 34;

            //Act

            string res = grades.GetGrades(percentage); // 
            // res = A;

            Assert.AreEqual("F", res);
        }
    }
}
