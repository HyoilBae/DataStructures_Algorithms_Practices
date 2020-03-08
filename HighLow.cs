using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            HighLow("1 2 3 4 5");
        }

        static void HighLow(string numString)
        {
            int max = 0;
            int min = 0;
            foreach (var item in numString.Split(' '))
            {
                if (Convert.ToInt32(item) > max)
                {
                    max = Convert.ToInt32(item);
                }
                if (Convert.ToInt32(item) < min)
                {
                    min = Convert.ToInt32(item);
                }
            }
            Console.WriteLine("{0} {1}", max, min);
        }
    }
}
