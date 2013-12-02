using System;

namespace _1126
{
    class MagnetData
    {
        private int size;
         
        public MagnetData(int size)
        {
            this.size = size;
        }

        private int MaxOfList(int[] list, int pos)
        {
            var max = 0;
            for (int i = pos; i < pos+size; i++)
            {
                if (list[i]>max)
                {
                    max = list[i];
                }
            }
            return max;
        }

        public void FastResult(int[] values,int count)
        {
            for (int i = 0; i <= count-size; i++)
            {
                Console.WriteLine(MaxOfList(values,i));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var memorySize = Int32.Parse(Console.ReadLine());
            var magnedData = new MagnetData(memorySize);
            int measurement;
            var measurements = new int[26000];
            var i = 0;
            while ((measurement=Int32.Parse(Console.ReadLine()))!=-1)
            {
                measurements[i++]=(measurement);
            }
            magnedData.FastResult(measurements,i);
        }
    }
}
