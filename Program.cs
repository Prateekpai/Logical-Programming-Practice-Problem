using System;
using System.Collections.Generic;
using System.Text;
namespace Fibonacci
{
    public class Program
    {
        public static void Main(string[]args)
        {
            int N1 = 0, N2 = 1, N3, i,number;
            Console.WriteLine("Enter the Number of Elements:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write(N1 + " " + N2 + " ");

            for (i = 2; i < number; i++)
            {
                N3 = N1 + N2;
                Console.Write(N3 + " ");
                N1 = N2;
                N2 = N3;
            }

        }
    }
}
