using System;
using System.Collections.Generic;

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
            var minimalTrivial =  Double.MaxValue;
            var minNumber = Int32.MaxValue;
            if (min == 1)
            {
                Console.WriteLine("1");
                return;
            }
            for (var i = max; i >= min; i--)
            {
                if (isPrime(i))
                {
                    minNumber = i;
                    break;
                    
                }
                var triv = TrivialForNumber(i);
                if (!(triv < minimalTrivial)) continue;
                minNumber = i;
                minimalTrivial = triv;
            }
            Console.WriteLine(minNumber);
        }

        static bool isPrime(int number)
        {
            var sqrt = Math.Sqrt(number);
            var prime = true;
            for (var i = 2; i <= sqrt; i++)
            {
                if (number%i != 0) continue;
                prime = false;
                break;
            }
            return prime;
        }

        static double TrivialForNumber(int number)
        {
            var sum = 0;
            var sqrt = number/2;

            for (var i = 2; i <= sqrt; i++)
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
