using System;
using System.Diagnostics;
namespace StopWatchDemo
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            Console.WriteLine("Time Elapaed {0}",stopwatch.Elapsed);
        }
    }
}
