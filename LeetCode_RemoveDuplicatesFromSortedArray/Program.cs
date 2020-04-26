using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.RemoveDuplicates(new int[]{ 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int index = 1;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] != nums[i+1])
                {
                    nums[index++] = nums[i + 1];
                }
            }

            return index;
        }
    }
}
