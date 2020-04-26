using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode_LetterCombinationOfAphoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            
            Console.WriteLine(String.Join(",", s.LetterCombinations("23")));


            //Console.WriteLine(String.Join(",", LetterCombinations2("23"))); 

        }

        static IList<string> LetterCombinations2(string digits)
        {
            List<string> result = new List<string>();
            

            string[] mapping =
            {
                 "0",
                "1",
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz"
            };

            //string nums = new string(digits.Where(Char.IsDigit).ToArray());

            //int firstNumber = Convert.ToInt32(nums[0]);
            //int secondNumber = Convert.ToInt32(nums[1]);

            //foreach (string hex in digits.Split())
            //{
            //    int value = Convert.ToInt32(hex, 16);
            //}

            

            string letterCombination1 = mapping[digits[0] - '0'];
            string letterCombination2 = mapping[digits[1] - '0'];

            Console.WriteLine("{0}, {1}", letterCombination1, letterCombination2);

            for (int i = 0; i < letterCombination1.Length; i++)
            {
                for (int j = 0; j < letterCombination2.Length; j++)
                {
                    result.Add(letterCombination1[i].ToString() + letterCombination2[j].ToString());
                }
            }

            return result;
        }
    }

    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();

            if (digits == null || digits.Length == 0)
            {
                return result;
            }

            string[] mapping =
            {
                "0",
                "1",
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz"
            };

            LetterCombinationsRecursive(result, digits, "", 0, mapping);
                return result;
                
        }

        public void LetterCombinationsRecursive(List<string> result, string digits, string current, int index, string[] mapping)
        {
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }

            string letters = mapping[digits[index] - '0'];
            for (int i = 0; i < letters.Length; i++)
            {
                LetterCombinationsRecursive(result, digits, current + letters[i], index + 1, mapping);
            }
        }
    }
}