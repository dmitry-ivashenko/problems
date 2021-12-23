
// 136. Single Number
// https://leetcode.com/problems/single-number/
// Difficulty: Easy

public class Solution {
    public int SingleNumber(int[] nums) {
        var x = 0;
        for (int i=0;i < nums.Length; i++)
        {
            x ^= nums[i];
        }
        return x;
    }
}
        