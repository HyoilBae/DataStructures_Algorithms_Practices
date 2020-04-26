using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(s.MaxArea(input));
        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int max = int.MinValue;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 0; j < height.Length; j++)
                {
                    int min = Math.Min(height[i], height[j]);
                    max = Math.Max(max, min * (j - i));
                }
               
            }

            return max;
        }
    }
}
