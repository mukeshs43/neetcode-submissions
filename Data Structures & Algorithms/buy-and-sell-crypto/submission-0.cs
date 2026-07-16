public class Solution {
    public int MaxProfit(int[] prices) {
        int maxprofit =0;
        for(int i=0;i<prices.Length;i++)
        {
            int profit =0;
           for(int j=i+1;j<prices.Length;j++)
           {
                profit = prices[j] - prices[i];
                maxprofit = Math.Max(profit,maxprofit);
           }
        }
        return maxprofit;
    }
}
