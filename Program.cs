using System;
using System.Collections.Generic;
using System.Text;
namespace PerfectNumber
{
    public class Program
    {
        public static void Main(string[]args)
        {
            int i, n, sum;
            int min, max;

            Console.WriteLine("Find the Perfect number within a given number of range ");

            Console.WriteLine("Enter the number of Strting range");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of Ending range");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Perfect Number within the given Range is :");

            {
                for (n=min; n<max;n++)
                {
                    i = 1;
                    sum = 0;
                    
                    while(i<n)
                    {
                        if (n % i == 0)
                            sum = sum + i;
                        i++;
                    }
                    if (sum == n)
                        Console.WriteLine("{0}", n);
                }
            }
        }
    }
}