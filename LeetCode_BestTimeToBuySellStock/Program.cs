using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_BestTimeToBuySellStock
{
    class Program
    {
        static int maxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                //looking for minimun price (valley)
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }

                //looking for maximun profit (Peak - Valley)
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(maxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
        }
    }
}
