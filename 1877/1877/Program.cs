using System;

namespace _1877
{
    class Program
    {
        static void Main(string[] args)
        {
            var code1 = Convert.ToInt32(Console.ReadLine());
            var code2 = Convert.ToInt32(Console.ReadLine());
            if(code1==0 || code1%2==0)Print(true);
            else if(code2%2!=0)Print(true);
            else Print(false);
        }

        static void Print(bool success)
        {
            Console.WriteLine(success ? "yes" : "no");
        }
    }
}
