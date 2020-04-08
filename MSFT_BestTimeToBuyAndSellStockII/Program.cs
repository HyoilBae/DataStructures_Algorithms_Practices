using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFT_BestTimeToBuyAndSellStockII
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 })); 


        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }
            else
            {
                int profit = 0;
                for (int i = 0; i < prices.Length-1; i++)
                {
                    if (prices[i + 1] > prices[i])
                    {
                        profit += prices[i + 1] - prices[i];
                    }
                }
            return profit;
            }
        }
    }

}
