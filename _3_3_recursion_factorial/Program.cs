using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_recursion_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(5));
        }

        private static int Fact(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            return x * Fact(x - 1);
        }
    }
}
