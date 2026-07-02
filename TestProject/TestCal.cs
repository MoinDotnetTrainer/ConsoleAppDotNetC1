using ClassLibraryOPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestCal
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void positiveResult()
        {
            int a = 1, b = 2;  //+ ope

            int res = Cal.Add(a, b);

            Assert.AreEqual(3, res);

        }
    }
}
