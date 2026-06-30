using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class RBIBank
    {
        public virtual void Withdraw()
        {
            Console.WriteLine("withdraw");
        }
        public virtual void Deposite()
        {
            Console.WriteLine("Deposite");
        }
        public void StaffSalary()
        {
            Console.WriteLine("Staff sal");
        }
        public void Loans()
        {
            Console.WriteLine("Loans");
        }
    }

    public class SBI : RBIBank
    {
        public override void Withdraw()
        {
            Console.WriteLine("withdraw SBI logic");
        }
       
        public new  void StaffSalary()
        {
            Console.WriteLine("Staff sal from SBI");
        }
    }
}
