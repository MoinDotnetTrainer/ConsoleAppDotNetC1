using Myproject;
using Banking;
using ControlStatements;
using ClassExample;
namespace ConsoleAppDotNetC1
{
    public class Program
    {
        
        static void Main(string[] args)  // enter point of the application
        {
            /* Console.WriteLine("Hello, World!");

             //gdfjk

             Demo d = new Demo(); // calling a demo to exe
             d.anyname();
             d.M1();
             d.M2();

             Sample s = new Sample();
             s.UserDetails();

             Datatypes dt = new Datatypes();
             dt.ExDatatypes();
            */

            // BoxingandUnboxing obj = new BoxingandUnboxing();
            //  obj.Test();

            //  Readline obj = new Readline();
            //  obj.Test();

            // Parsing obj = new Parsing();
            // obj.test();

            //Myproject.DataTypes obj = new DataTypes();
            //obj.Test();

            //BankingOps bank = new BankingOps();
            //bank.Deposite();

            // Looping looping = new Looping();
            //  looping.LoopTest();

            //Users obj = new Users();
            //obj.UserPersonalData();
            //obj.FamilyData();
            //obj.Quali();
            //obj.Hobbies();

            //Sample s = new Sample();
            //s.Add();
            //s.Sub(12,2);
            //s.Sub(y:234,x:56);  // named argument
            //s.Sub(34,45);
            //s.Sub(34,5);
            //s.Userdata("xyz","hyd");

            /* ReturnType r = new ReturnType();
             r.Add();  // memory
             int res = ReturnType.Sub();
             if (res == 0)
             {
                 Console.WriteLine("do this");
             }
             else
             {
                 Console.WriteLine(" do that");
             }

             (int sno, string msg) = r.M1();
             Console.WriteLine(sno);
             Console.WriteLine(msg);

             StaticMethod.M1();


             MethodOverloading.M1();
            */

            // Staticlass1.M1();
            // Staticlass1.M2();

            //   ConstrExample obj = new ConstrExample(23,"hi");



            //Orders.Inventory();
            //Orders.Sales();
            //Orders.Profit();


            Parent p = new Parent();
           // p.Add();
           // p.Sub();
            Child c = new Child();
            c.Mul();
            // c.Div();

            c.Add();
            c.Sub();

        }
    }
}
