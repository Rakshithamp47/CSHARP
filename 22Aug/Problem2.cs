using System;
public class Problem2
{
    public static void Main()
    {
        int i, n;
        int[] a = new int[100];

        Console.Write("Number of elements to store in the array :");
        n = Convert.ToInt32(Console.ReadLine());


        Console.Write("Input {0} number of elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\n\nThe array in reverse order are :\n");
        for (i = n - 1; i >= 0; i--)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.Write("\n\n");
    }
}