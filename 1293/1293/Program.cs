using System;

namespace _1293
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ');
            var N = Convert.ToInt32(inputNumbers[0]);
            var A = Convert.ToInt32(inputNumbers[1]);
            var B = Convert.ToInt32(inputNumbers[2]);
            var sumWeight = 2*N*A*B;
            Console.WriteLine(sumWeight);
        }
    }
}
