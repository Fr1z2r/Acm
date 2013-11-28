using System;

namespace _1409
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers=Console.ReadLine().Split(' ');
            var first = Convert.ToInt32(inputNumbers[0]);
            var second = Convert.ToInt32(inputNumbers[1]);
            var sum = first + second - 1;
            Console.WriteLine((sum-first)+" "+(sum-second));
        }
    }
}
