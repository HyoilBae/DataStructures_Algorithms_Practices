using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_BestTimeToBuyAndSellStocl
{
    class Program
    {
        static int maxProfit(int[] prices)
        {
            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i-1])
                {
                    maxprofit += prices[i] - prices[i - 1];
                }
            }
            return maxprofit;
        }
        static void Main(string[] args)
        {
            int[] userInput = new int[] { 7, 1, 5, 3, 6, 4 };

            Console.WriteLine(maxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
        }
    }
}
