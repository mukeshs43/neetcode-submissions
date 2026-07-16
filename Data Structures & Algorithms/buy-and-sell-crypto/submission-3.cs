public class Solution {
    public int MaxProfit(int[] prices) {
        int min =prices[0];
        int maxprofit =0;
        for(int i=0;i<prices.Length;i++)
        {
           min = Math.Min(min,prices[i]);
           maxprofit = Math.Max(maxprofit,prices[i]-min);
           
        }
        return maxprofit;
    }
}
