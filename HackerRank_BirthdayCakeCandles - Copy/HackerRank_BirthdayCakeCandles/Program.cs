using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            int max = ar[0];
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                }
            }

            for (int j = 0; j < ar.Length; j++)
            {
                if (ar[j] == max)
                {
                    count++;
                }
            }
            return count;


            //int height = ar[0];
            //int count = 1;
            //for (int i = 1; i < ar.Count(); i++)
            //{
            //    if (ar[i] > height)
            //    {
            //        height = ar[i];
            //        count = 1;
            //    }
            //    else if (ar[i] == height)
            //    {
            //        count++;
            //    }
            //}
            //return count;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            
            int result = birthdayCakeCandles(ar);
            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
