using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
            //Ex {1, 2, 3, 4, 5}
        }

        static void miniMaxSum(int[] arr)
        {
            int sum = 0;
            int max = 0;
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    sum = sum + arr[j];
                }
                sum = sum - arr[i];
                if (sum > max)
                {
                    max = sum;
                }
                
                
            }

            Console.WriteLine("{0} {1}", min, max);


        }
    }
}
