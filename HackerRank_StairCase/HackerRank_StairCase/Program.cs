using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_StairCase
{
    class Program
    {
        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {

                string space = new string(' ', n - i);
                Console.Write(space);

                string sharp = new string('#', i);
                Console.Write(sharp);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
