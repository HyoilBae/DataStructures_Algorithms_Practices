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

            int givenNumber = 42;
            //Console.WriteLine(isItSingleDigit(givenNumber));
            sumUpAllNumber(givenNumber);


        }

        static void sumUpAllNumber(int intNumber)
        {
            int sum = 0;

            while (sum < 10)
            {
                if (isItSingleDigit(intNumber))
                {
                    Console.WriteLine(intNumber);
                    break;
                }
                else
                {
                    int lastNumber = intNumber % 10;
                    sum = sum + lastNumber;
                    intNumber = intNumber / 10;
                }
            }
            Console.WriteLine(sum);
                        

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
