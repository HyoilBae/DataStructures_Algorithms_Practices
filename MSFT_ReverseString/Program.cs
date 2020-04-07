using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFT_ReverseString
{
    public class Solution
    {
        public void ReverseString(string str)
        {
            char[] s = str.ToCharArray();

            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                char tmp = s[left];
                s[left++] = s[right];
                s[right--] = tmp;
            }
            Console.WriteLine(s);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            s.ReverseString("Hello");
        }
    }
}
