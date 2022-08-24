using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aug23Handson
{
    internal class Program1
    {
        static void add(int i, int j)
        {
            int sum = i + j;
            Console.WriteLine("The sum of two integers " + sum);
        }
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int j = Convert.ToInt32(Console.ReadLine());
            add(i, j);

        }
    }
}