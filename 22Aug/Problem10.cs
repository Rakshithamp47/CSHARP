using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug22Handson
{
    internal class Problem10
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Rakshitha");
            dic.Add(2, "Shreyas");

            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.ReadKey();
        }
    }
}