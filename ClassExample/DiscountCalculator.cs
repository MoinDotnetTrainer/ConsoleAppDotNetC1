using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class DiscountCalculator
    {
        public double CalculateDiscount(string customerType, double amount)
        {
            if (customerType == "Regular")
            {
                return amount * 0.1;
            }
            else if (customerType == "Premium")
            {
                return amount * 0.2;
            }
            else if (customerType == "VIP")
            {
                return amount * 0.3;
            }
            else if (customerType == "Staff")
            {
                return amount * 0.4;
            }

            // VIP 0.3
            // Staff 0.4
            return 0;
        }
    }
}
