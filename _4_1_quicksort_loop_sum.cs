using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_quicksort_loop_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
        }

        private static int Sum(IEnumerable<int> arr)
        {
            var total = 0;
            foreach (var x in arr)
            {
                total += x;
            }
            return total;
        }
    }
}
