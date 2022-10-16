
// 309. Best Time to Buy and Sell Stock with Cooldown
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/
// Difficulty: Medium

public class Solution {
    public int MaxProfit(int[] prices) {
        int sold = 0, rest = 0, hold = Int32.MinValue;
        
        for (int i = 0; i < prices.Length; i++) {
            int prevSold = sold;
            sold = hold + prices[i];
            hold = Math.Max(hold, rest - prices[i]);
            rest = Math.Max(rest, prevSold);
        }
        return Math.Max(sold, rest);
    }
}
        