﻿using System;
using System.Collections.Generic;
using System.Text;
namespace CouponNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Distinct Number N:");
            int n = Convert.ToInt32(Console.ReadLine());

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            var stringChars = new char[6];
            var random = new Random();

            int j = 0;
            while (j < n)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                Console.WriteLine(stringChars);
                j++;
            }
            

            //var finalString = new String(stringChars);
        }

    }
}
