using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", singleDigitSum(41)));
        }

        public static int singleDigitSum(int x)
        {
            int sum = 0;
            int check = 10;

            while (check > 9)
            {
                sum = 0;
                while (x > 0 )
                {
                    sum = x % 10 + sum;
                    x = x / 10;
                }
                x = sum;
                check = sum;
            }
            return sum;
        }
    }
}
