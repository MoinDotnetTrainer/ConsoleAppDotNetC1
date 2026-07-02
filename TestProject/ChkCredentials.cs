using ClassLibraryOPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ChkCredentials
    {
        private Login _login;
        [SetUp]
        public void Setup()
        {
            _login = new Login();
        }

        [Test]
        public void TestValidCredentials()
        {
            // Arrange
            string username = "admin";
            string password = "password123";
            // Act
            bool result = _login.ValidateUser(username, password);
            // Assert
            Assert.IsTrue(result);
        }



        [Test]
        public void TestInvalidValidCredentials()
        {
            // Arrange
            string username = "admin123";
            string password = "password123";
            // Act
            bool result = _login.ValidateUser(username, password);
            // Assert
            Assert.IsFalse(result);
        }

    }
}
