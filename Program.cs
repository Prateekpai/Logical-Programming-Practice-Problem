using System;
using System.Collections;
using System.Text;
namespace ReverseNumber
{
    public class Program
    {
        public static void Main(string[]args)
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
