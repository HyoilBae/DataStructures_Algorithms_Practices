using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_FindAllMissingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(String.Join(",", s.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 })));
        }
    }

    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> missingNumbers = new List<int>();
            //List<int> numbers = new List<int>();
            HashSet<int> numbers = new HashSet<int>();

            foreach (int i in nums)
            {
                numbers.Add(i);
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (!numbers.Contains(i))
                {
                    missingNumbers.Add(i);
                }
            }
            return missingNumbers;
        }
    }
}
