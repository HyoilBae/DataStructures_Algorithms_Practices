using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_BetweenTwoSets
{
    class Result
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            int total = 0;
            int number = a.Max();

            Enumerable.Range(number, b.Min())
                .ToList()
                .ForEach(n =>
                {
                    if (a.All(e => number % e == 0 || e % number == 0)
                        && b.All(e => number % e == 0 || e % number == 0))
                        total++;

                    number++;
                });

            return total;

            ///*Starting from 0 found, storing largest value in A and smallest value in b. Setting starting point to largest value in A.*/
            //int foundCount = 0, maxA = a.Max(), minB = b.Min(), current = maxA;
            //while (current <= minB)
            //{
            //    /*If the current value is divisible by all members of both arrays, then it's the one we want.*/
            //    if (a.All(e => current % e == 0 || e % current == 0) && b.All(e => current % e == 0 || e % current == 0))
            //        foundCount++;
            //    /*Iterate the value by largest member of divisors, no reason to take smaller steps.*/
            //    current += maxA;
            //};
            //return foundCount;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.getTotalX(arr, brr);

            Console.WriteLine(total);

            //textWriter.WriteLine(total);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}

