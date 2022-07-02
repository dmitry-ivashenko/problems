
// 169. Majority Element
// https://leetcode.com/problems/majority-element/
// Difficulty: Easy

public class Solution {
    public int MajorityElement(int[] nums) {
        int res = 0;
        int count = 0;

        for(var i = 0; i < nums.Length; i ++){
            if (count == 0){
                res = nums[i];
            }
            count += (nums[i] == res) ? 1 : -1;
        }
        return res;
    }
}
        