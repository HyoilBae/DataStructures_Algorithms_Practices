using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CountAndSay
{
    class Program
    {
        public static string CountAndSay(int n)
        {

            //if (n <= 0) return "";

            if (n == 1) return "1";

            var result = new StringBuilder("1");

            while (n > 1)
            {
                var tempResult = new StringBuilder();

                int count = 1;
                for (int i = 1; i < result.Length; i++)
                {
                    if (result[i - 1] == result[i])
                    {
                        count++;
                    }
                    else
                    {
                        tempResult.Append(count);
                        tempResult.Append(result[i - 1]);
                        count = 1;
                    }
                }

                // This part is easy to forget
                tempResult.Append(count);
                tempResult.Append(result[result.Length - 1]);

                result = tempResult;

                n--;
            }

            return result.ToString();

        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountAndSay(4));
        }
    }
}
