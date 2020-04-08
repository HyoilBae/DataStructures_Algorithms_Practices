using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_recursion_countDown
{
    class _3_1_recursion_countDown
    {
        static void Main(string[] args)
        {
            CountDown(5);
        }

        private static void CountDown(int i)
        {
            Console.WriteLine(i);

            //base case
            if (i <= 0)
            {
                return;
            }

            //recursive case
            CountDown(i - 1);
        }
    }
}
