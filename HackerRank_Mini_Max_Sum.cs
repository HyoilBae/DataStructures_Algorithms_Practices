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
            //miniMaxSum(arr);
            //Ex {1, 2, 3, 4, 5}
            miniMaxSum1(arr);
            
            
        }
        static void miniMaxSum1(int[] arr)
        {
            List<double> intList = new List<double>();

            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    sum = sum + arr[j];
                }
                sum = sum - arr[i];
                intList.Add(sum);
                sum = 0;
            }

            double max = Math.Round(intList.Max(), 10);
            double min = Math.Round(intList.Min(), 10);

            Console.WriteLine("{0} {1}", min, max);


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

                if (min == 0)
                {
                    min = sum;
                }
                else if(sum < min)
                {
                    min = sum;
                }
                sum = 0;
            }
            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
