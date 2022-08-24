using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug22Handson
{
    internal class Problem8
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "Rakshitha");
            h.Add(2, "Shreyas");
            h.Add(3, "Rajesh");
            h.Add(4, "Naksh");
            h.Add(5, "Yash");
            IDictionaryEnumerator ie = h.GetEnumerator();
            while (ie.MoveNext())
            {
                {
                    Console.WriteLine(ie.Key + "  " + ie.Value);
                }
                Console.WriteLine("Using for each");
                foreach (DictionaryEntry item in h)
                {
                    Console.WriteLine(item.Key + "  " + item.Value);

                }

            }
            Console.ReadLine();
        }
    }
}