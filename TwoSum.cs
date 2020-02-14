using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;
            //int[] nums = { 3, 3 };
            int[] nums = { 3, 2, 4 };
            int target = 6;

            Solution solution = new Solution();
            int[] result = solution.TwoSum(nums, target);

      
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new ArgumentException("No twoo sum solution");
            

            //int[] answer = new int[2];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (i == j)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            if (nums[i] + nums[j] == target)
            //            {
            //                answer[0] = i;
            //                answer[1] = j;
            //            }
            //            //break;
            //        }
            //        //break;
            //    }
            //    //break;

            //}
            //return answer;

        }
    }
}
