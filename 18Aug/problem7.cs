using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1HandsOn
{
    internal class problem7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int i1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", i1);
            Console.WriteLine("{0}{0}{0}{0}", i1);
            Console.WriteLine("{0} {0} {0} {0}", i1);
            Console.WriteLine("{0}{0}{0}{0}", i1);
        }
    }
}