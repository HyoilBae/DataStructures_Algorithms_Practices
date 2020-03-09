using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            foreach (double i in arr)
            {
                if (i > 0)
                {
                    positive++;
                }
                else if(i == 0)
                {

                    zero++;
                }
                else if(i < 0)
                {
                    negative++;
                }


            }
            double pos = ((double)positive / (double)arr.Length);
            Console.WriteLine(pos);
            double neg = Math.Round(((double)negative / (double)arr.Length), 6);
            Console.WriteLine(neg);
            double zer = Math.Round(((double)zero / (double)arr.Length), 6);
            Console.WriteLine(zer);


        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            
            plusMinus(arr);
        }
    }
}
