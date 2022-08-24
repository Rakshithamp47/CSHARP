using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug24Handson
{
    internal class Problem2
    {
        static void Main(string[] args)
        {

            string str1 = "Rakshitha";
            string str2 = "MP";
            Console.WriteLine("Original Strings are str1 = " + "'{0}' and str2='{1}'", str1, str2);

            Console.WriteLine("");

            Console.WriteLine("After Copy");
            Console.WriteLine("");

            str2 = String.Copy(str1);

            Console.WriteLine("Strings are str1 = " + "'{0}' and str2='{1}'", str1, str2);
        }
    }
}