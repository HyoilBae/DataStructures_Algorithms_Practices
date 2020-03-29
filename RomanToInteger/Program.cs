using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Enter Roman Number : ");
            string userInput = Console.ReadLine();
            int romanToInt = solution.RomanToInt(userInput);
            Console.WriteLine(romanToInt);
        }

       
    }

    public class Solution
    {
        public int RomanToInt(string s)
        {

            Dictionary<char, int> romanDictionary = new Dictionary<char, int>();
            romanDictionary.Add('I', 1);
            romanDictionary.Add('V', 5);
            romanDictionary.Add('X', 10);
            romanDictionary.Add('L', 50);
            romanDictionary.Add('C', 100);
            romanDictionary.Add('D', 500);
            romanDictionary.Add('M', 1000);

            int result = romanDictionary[s[s.Length - 1]];

            for (int i = s.Length - 1; i > 0; i--)
            {
                if (romanDictionary[s[i]] <= romanDictionary[s[i - 1]])
                {
                    result += romanDictionary[s[i - 1]];
                }
                else
                {
                    result -= romanDictionary[s[i - 1]];
                }
            }

            return result;


            //    int intRoman = 0;
            //    //int[] intRomanArray = new int[10];
            //    ArrayList intRomanAL = new ArrayList();

            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (s.Substring(i, 1) == "I")
            //        {
            //            intRomanAL.Add(1);
            //        }

            //        else if (s.Substring(i, 1) == "V")
            //        {
            //            if (i == 0)
            //            {
            //                intRomanAL.Add(5);
            //            }
            //            else if (s.Substring(i - 1, 1) == "I")
            //            {
            //                intRomanAL.Add(3);
            //            }
            //            else
            //            {
            //                intRomanAL.Add(5);
            //            }
            //        }

            //        else if (s.Substring(i, 1) == "X")
            //        {
            //            if (i == 0)
            //            {
            //                intRomanAL.Add(10);
            //            }
            //            else if (s.Substring(i - 1, 1) == "I" && i != 0)
            //            {
            //                intRomanAL.Add(8);
            //            }
            //            else
            //            {
            //                intRomanAL.Add(10);
            //            }
            //        }

            //        else if (s.Substring(i, 1) == "L")
            //        {
            //            if (i == 0)
            //            {
            //                intRomanAL.Add(50);
            //            }
            //            else if (s.Substring(i - 1, 1) == "X" && i != 0)
            //            {
            //                intRomanAL.Add(30);
            //            }
            //            else
            //            {
            //                intRomanAL.Add(50);
            //            }
            //        }

            //        else if (s.Substring(i, 1) == "C")
            //        {
            //            if (i == 0)
            //            {
            //                intRomanAL.Add(100);
            //            }
            //            else if (s.Substring(i - 1, 1) == "X" && i != 0)
            //            {
            //                intRomanAL.Add(80);
            //            }
            //            else
            //            {
            //                intRomanAL.Add(100);
            //            }
            //        }

            //        else if (s.Substring(i, 1) == "D")
            //        {
            //            if (i == 0)
            //            {
            //                intRomanAL.Add(500);
            //            }
            //            else if (s.Substring(i - 1, 1) == "C" && i != 0)
            //            {
            //                intRomanAL.Add(300);
            //            }
            //            else
            //            {
            //                intRomanAL.Add(500);
            //            }
            //        }

            //        else if (s.Substring(i, 1) == "M")
            //        {
            //            if (i == 0)
            //            {
            //                intRomanAL.Add(1000);
            //            }
            //            else if (s.Substring(i - 1, 1) == "C" && i != 0)
            //            {
            //                intRomanAL.Add(800);
            //            }
            //            else
            //            {
            //                intRomanAL.Add(1000);
            //            }
            //        }
            //    }
            //    foreach (int item in intRomanAL)
            //    {
            //        intRoman += item;
            //    }
            //    return intRoman;
            }
        }
}
