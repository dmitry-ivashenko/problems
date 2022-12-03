
// 724. Find Pivot Index
// https://leetcode.com/problems/find-pivot-index/
// Difficulty: Easy

public class Solution {
    public int PivotIndex(int[] nums) {
        int total = nums.Sum();
        
        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == total - leftSum - nums[i])
            {
                return i;
            }

            leftSum += nums[i];
        }
        return -1;
    }
}
        