using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MSFT_ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string s1 = "A man, a plan, a canal: Panama";
            Console.WriteLine(s.IsPalindrome(s1));
        }
    }

    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                while (i < j && !char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }

                while (i < j && !char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }

                if (i < j && (char.ToLower(s[i++]) != char.ToLower(s[j--])))
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
