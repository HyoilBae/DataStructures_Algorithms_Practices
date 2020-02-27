using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_AveryBigSum
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum = sum + ar[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int arCount = Convert.ToInt32(Console.ReadLine());
            int arCount = Convert.ToInt32(Console.ReadLine());
            //long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            //long result = aVeryBigSum(ar);
            long result = aVeryBigSum(ar);
            //textWriter.WriteLine(result);
            Console.WriteLine(result);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
