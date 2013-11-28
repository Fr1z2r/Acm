using System;
using System.Linq;

namespace _1068
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Enumerable.Range(number>0?1:number, Math.Abs(number - 1) + 1).Sum());
        }
    }
}
