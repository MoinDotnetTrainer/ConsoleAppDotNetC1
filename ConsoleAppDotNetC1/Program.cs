using Banking;
using ClassExample;
using ClassLibraryForLINQ;
using ControlStatements;
using Myproject;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
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


            // Parent p = new Parent();
            // p.Add();
            // p.Sub();
            // Child c = new Child();
            // c.Mul();
            // c.Div();

            // c.Add();
            // c.Sub();

            //  ChildClass obj = new ChildClass();

            //RBIBank bank = new RBIBank();
            //bank.Withdraw();
            //bank.Deposite();
            //bank.StaffSalary();
            //bank.Loans();

            //SBI sbi = new SBI();
            //sbi.Withdraw();
            //sbi.StaffSalary();

            //ExceptionHandling.Div();


            //   refout.Exe();


            /*  try
              {
                  Props.x_ = 34;
                  Props.y_ = 34;
                  Props.Add();
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex.Message);
              }
            */

            //OutKeyword.Cal(12, 3, out int add, out int sub);
            //Console.WriteLine(add);
            //Console.WriteLine(sub);


            //Products obj = new Products();
            //obj.ProductsInv();
            //obj.ProductsSales();

            /*  GenMethod.Test(12, 34);
              GenMethod.Test1<int>(23, 2); // method with type as an argument  
              GenMethod.Test1<string>("23", "hi");
              GenMethod.Test1<bool>(true, false);

              GenMethod.Test2<int, string>(12, "hi");
              GenMethod.Test2<int, int>(12, 23);
              GenMethod.Test2<string, string>("12", "hi");
            */



            /* GenClass<int> obj = new GenClass<int>();
             obj.Test1(12);

             obj.Test2(12, 67);

             GenClass<bool> obj1 = new GenClass<bool>();
             obj1.Test1(true);

             obj1.Test2(true, false);

             GenClass<string> obj2 = new GenClass<string>();
            */

            // Collections.NonGen();

            // AddData.AddStdData();

            /* DelegatesExample obj = new DelegatesExample();
             //obj.Add();  --> spin 
             //obj.Sub();  --> dry 
             //obj.Mul(12,2); -->
             //obj.Div(12,2);

             MyDelegate1 mydel = new MyDelegate1(obj.Add);
             mydel.Invoke();

             MyDelegate1 mydel1 = new MyDelegate1(obj.Sub);
             mydel1.Invoke();

             // single cast & multi cast

             MyDelegate2 mydel2 = new MyDelegate2(obj.Mul);
             mydel2 += new MyDelegate2(obj.Div);
             mydel2 -= new MyDelegate2(obj.fact);
             //+=
             mydel2.Invoke(12,2);  // caller function is decideing what to exe wjat not to exe


             // Y we need to use delegates

             // Washing machine --> 
             // switch -->water --> surf --> comfort --> spin --> soak

             */


            // Unamed methods or annomnus methods 


            /*  CallingDel obj = delegate ()
              {
                  Console.WriteLine("one line of Code ");
              };
              obj.Invoke();

              CallingDel obj1 = () =>
              {
                  Console.WriteLine("Exe");
              };
              obj1.Invoke();


              CallingDel1 obj2 = (x) =>
              {
                  Console.WriteLine("Exe");
                  return x;
              };
              obj2.Invoke(23);

              */



            // sub threads using thread class

            /*  Thread t1 = new Thread(MultiThread.M1);  // t1 sub thread
              Thread t2 = new Thread(MultiThread.M2);  // t2 sub thread

              t1.Start();
              t2.Start();

              */


            /*   Task t1 = new Task(AsyncProggramming.Exe1);
               t1.Start();
               t1.Wait();
               Console.ReadKey();

               */

            //LinqExamples.Ex();

            Lookup.T1();
        }
    }
}
