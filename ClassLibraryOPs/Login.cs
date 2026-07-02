using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOPs
{
    public class Login
    {
        public bool ValidateUser(string username, string password)
        {
            // For demonstration purposes, we'll use hardcoded credentials.
            // In a real application, you would check against a database or other secure storage.
            const string validUsername = "admin";
            const string validPassword = "password123";
            return username == validUsername && password == validPassword;
        }
    }
}
