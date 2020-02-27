using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panlindrome_Numbers_Single_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Palindrome Question [White Boarding Exercises]
             * Find a signle digit number by adding each single number in given either single number or multiple numbers
             * 
             */

            //1. Check if given number is already a signle digit number
            //   Or is it 0?
            //   Or is it multiple numbers?
            //   Or is it negative?

            int givenNumber = 4315;
            //Console.WriteLine(isItSingleDigit(givenNumber));
            sumUpAllNumber(givenNumber);


        }

        static void sumUpAllNumber(int intNumber)
        {
            

            //while (sum < 10) // this is wrong
            if (isItSingleDigit(intNumber) || intNumber == 0)
            {
                Console.WriteLine(intNumber);
            }
            else
            {
                int sum = 11;
                while (sum > 9)
                {
                    sum = 0;
                    while (intNumber > 9)
                    {
                    int lastDigit = intNumber % 10;
                    intNumber = intNumber / 10;
                    sum = sum + lastDigit;
                    }
                    sum = sum + intNumber;
                }
                Console.WriteLine(sum);

            }



        }

        static bool isItSingleDigit(int intNumber)
        {
            string stringGivenNumber = intNumber.ToString();
            if (stringGivenNumber.Length < 2)
            {
                //Console.WriteLine(intNumber);
                return true;
            }
            else
            {
                //Console.WriteLine(intNumber);
                return false;
            }

            //Console.WriteLine(stringGivenNumber);
            //Console.WriteLine(stringGivenNumber.GetType());
            //Console.Write(stringGivenNumber[0]);
            //Console.Write(stringGivenNumber[1]);
        }
    }
}
