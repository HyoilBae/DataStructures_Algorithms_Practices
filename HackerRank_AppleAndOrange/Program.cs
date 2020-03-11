using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_AppleAndOrange
{
    class Program
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                if ((s <= a + apples[i]) && (a + apples[i] <= t))
                {
                    appleCount++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                if ((s <= b + oranges[i]) && (b + oranges[i] <= t))
                {
                    orangeCount++;
                }
            }

            Console.WriteLine($"{appleCount} \n{orangeCount}");
        }
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
