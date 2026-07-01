using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public interface IDiscount
    {
        double CalculateDiscount(string customerType, double amount);   
    }

    public class RegularCustomerDiscount : IDiscount
    {
        public double CalculateDiscount(string customerType, double amount)
        {
            return amount * 0.1;
        }
    }

    public class PermiumCustomerDiscount : IDiscount
    {
        public double CalculateDiscount(string customerType, double amount)
        {
            return amount * 0.2;
        }
    }

    public class VipCustomerDiscount : IDiscount
    {
        public double CalculateDiscount(string customerType, double amount)
        {
            return amount * 0.3;
        }
    }
    public class StaffCustomerDiscount : IDiscount
    {
        public double CalculateDiscount(string customerType, double amount)
        {
            return amount * 0.4;
        }
    }
}
