using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_quicksort_recursive_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count(new[] { 1, 2, 3, 4 }));
        }
        private static int Count(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return 1 + Count(list.Skip(1));
        }
    }
}
