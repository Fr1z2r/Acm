using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = "1,1e30";
            //Convert.ToDouble(num);
            double res;
            var numbers = num.Split('e');
            double mainPart;
            int pow;
                Double.TryParse(numbers[0], out mainPart);
            Int32.TryParse(numbers[1], out pow);
            res = mainPart*Math.Pow(10, pow);
            //Double.TryParse(num, out res);
            //double a = 1.1;
            Double.TryParse(num, out res);
             Console.WriteLine(String.Format("{0,20}",res));
            Console.WriteLine(res);
            var format = 10;
        }

        static double newNum()
        {
            return 0;
        }
    }
}
