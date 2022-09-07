using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Sept6Handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p;
            p = new Employee();
            p.work();
            p = new Manager();
            p.work();
            p = new Clerk();
            p.work();    //1

            Bank b1 = new Bank();
            b1.print_balance();
            b1.calc_interest();     //2

            Console.WriteLine("savings account");
            Ibank2 b = new Saving();
            b.print_balance();
            b.calc_interest();
            Console.WriteLine("current aacount");
            Ibank2 b2 = new Current();
            b2.print_balance();
            b2.calc_interest();   //3
        }
    }
}