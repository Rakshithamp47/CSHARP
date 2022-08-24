using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug23Handson
{
    internal class Program2
    {
        static int add(int i, int j)
        {
            int sum = i + j;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int j = Convert.ToInt32(Console.ReadLine());
            int sum = add(i, j);
            Console.WriteLine("The sum of two integers: " + sum);
        }
    }
}