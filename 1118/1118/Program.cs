using System;
using System.Collections.Generic;
using System.Linq;

namespace _1118
{
    class Program
    {
        public static Dictionary<int, int> dict = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            var min = Convert.ToInt32(numbers[0]);
            var max = Convert.ToInt32(numbers[1]);
            if (min < max/2) min = (int)Math.Ceiling((double)max/2);
            Console.WriteLine(Enumerable.Range(min, max - min + 1).ToDictionary(n=>n,TrivialForNumber).OrderBy(kvp => kvp.Value).First().Key);
        }

        static double TrivialForNumber(int number)
        {
            var sum = 0;
            var sqrt = number/2;

            for (var i = 1; i <= sqrt; i++)
            {
                if (number%i==0)
                {
                    sum += i;
                }
            }
            return (double)sum/number;
        }
    }
}
